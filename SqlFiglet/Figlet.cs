using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void FigletPrint(SqlString Font, SqlBoolean PrintCommentTags, SqlString Text)
    {
        Figlet figlet = new Figlet();
        figlet.PrintText(Font.ToString(), (bool)PrintCommentTags, Text.ToString());
    }

    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void FigletHelp()
    {
        Figlet figlet = new Figlet();
        foreach (System.Reflection.PropertyInfo pi in Type.GetType("Figlet").GetProperties())
        {
            SqlContext.Pipe.Send(string.Format("\n\nFont name: {0}", pi.Name));
            figlet.PrintText(pi.Name, false, "Sql Server Rocks!");
        }

    }
}

public partial class Figlet
{
    private string[] fontdata;
    private string HardBlank;
    private int Height;
    private int CommentLines;

    public void PrintText(string Font, bool PrintCommentTags, string Text)
    {
        LoadFontData(Font);

        if (PrintCommentTags)
        {
            SqlContext.Pipe.Send("/*");
        }

        string StringData;

        for (int i = 1; i <= Height; i += 1)
        {
            StringData = "";
            for (int CharPos = 0; CharPos < Text.ToString().Length; CharPos += 1)
            {
                StringData += GetCharacter(Text.Substring(CharPos, 1), i);
            }
            SqlContext.Pipe.Send(StringData);
        }

        if (PrintCommentTags)
        {
            SqlContext.Pipe.Send("*/\n");
        }

    }

    private string GetCharacter(string Char, int i)
    {
        int ASCII = System.Text.Encoding.ASCII.GetBytes(Char)[0] - 32;
        string FontDataLine = fontdata[CommentLines + (ASCII * Height) + i].Replace(HardBlank, " ");
        string EndChar = FontDataLine.Substring(FontDataLine.Length - 1);

        if (FontDataLine.EndsWith(EndChar + EndChar))
        {
            FontDataLine = FontDataLine.Substring(0, FontDataLine.LastIndexOf(EndChar + EndChar));
        }
        else if (FontDataLine.EndsWith(EndChar))
        {
            FontDataLine = FontDataLine.Substring(0, FontDataLine.LastIndexOf(EndChar));
        }

        return FontDataLine;
    }

    private void LoadFontData(string Font)
    {
        try
        {
            fontdata = Type.GetType("Figlet").GetProperty(Font).GetValue(this, null).ToString().Split('\n');
        }
        catch
        {
            throw new Exception("Invalid Font Name");
        }

        string[] tmp = fontdata[0].Split(' ');

        if (tmp[0].Substring(0, 5) != "flf2a")
        {
            throw new Exception("String is not a valid Figlet font");
        }

        HardBlank = tmp[0].Substring(5, 1);
        Height = int.Parse(tmp[1]);
        CommentLines = int.Parse(tmp[5]);
    }
}
