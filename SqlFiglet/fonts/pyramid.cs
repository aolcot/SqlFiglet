public partial class Figlet
{
    public string Pyramid { get { return pyramid; } }
    private string pyramid = @"flf2a� 3 3 7 -1 16
Pyramid by Claude Martins 02/95
Includes characters 128-255
figlet release 2.1 -- 12 Aug 1994
Permission is hereby given to modify this font, as long as the
modifier's name is placed on a comment line.

Explanation of first line:
flf2 - ""magic number"" for file identification
a    - should always be `a', for now
$    - the ""hardblank"" -- prints as a blank, but can't be smushed
3    - height of a character
3    - height of a character, not including descenders
7   - max line length (excluding comment lines) + a fudge factor
-1   - default smushmode for this font
16   - number of comment lines

���@
���@
���@@
  ^  @
 /!\ @
<___>@@
  ^  @
 /""\ @
<___>@@
  ^  @
 /#\ @
<___>@@
  ^  @
 /$\ @
<___>@@
  ^  @
 /%\ @
<___>@@
  ^  @
 /&\ @
<___>@@
  ^  @
 /'\ @
<___>@@
  ^  @
 /(\ @
<___>@@
  ^  @
 /)\ @
<___>@@
  ^  @
 /*\ @
<___>@@
  ^  @
 /+\ @
<___>@@
  ^  @
 /,\ @
<___>@@
  ^  @
 /-\ @
<___>@@
  ^  @
 /.\ @
<___>@@
  ^  @
 //\ @
<___>@@
  ^  @
 /0\ @
<___>@@
  ^  @
 /1\ @
<___>@@
  ^  @
 /2\ @
<___>@@
  ^  @
 /3\ @
<___>@@
  ^  @
 /4\ @
<___>@@
  ^  @
 /5\ @
<___>@@
  ^  @
 /6\ @
<___>@@
  ^  @
 /7\ @
<___>@@
  ^  @
 /8\ @
<___>@@
  ^  @
 /9\ @
<___>@@
  ^  @
 /:\ @
<___>@@
  ^  @
 /;\ @
<___>@@
  ^  @
 /<\ @
<___>@@
  ^  @
 /=\ @
<___>@@
  ^  @
 />\ @
<___>@@
  ^  @
 /?\ @
<___>@@
  ^  @
 /@\ @
<___>@@
  ^  @
 /A\ @
<___>@@
  ^  @
 /B\ @
<___>@@
  ^  @
 /C\ @
<___>@@
  ^  @
 /D\ @
<___>@@
  ^  @
 /E\ @
<___>@@
  ^  @
 /F\ @
<___>@@
  ^  @
 /G\ @
<___>@@
  ^  @
 /H\ @
<___>@@
  ^  @
 /I\ @
<___>@@
  ^  @
 /J\ @
<___>@@
  ^  @
 /K\ @
<___>@@
  ^  @
 /L\ @
<___>@@
  ^  @
 /M\ @
<___>@@
  ^  @
 /N\ @
<___>@@
  ^  @
 /O\ @
<___>@@
  ^  @
 /P\ @
<___>@@
  ^  @
 /Q\ @
<___>@@
  ^  @
 /R\ @
<___>@@
  ^  @
 /S\ @
<___>@@
  ^  @
 /T\ @
<___>@@
  ^  @
 /U\ @
<___>@@
  ^  @
 /V\ @
<___>@@
  ^  @
 /W\ @
<___>@@
  ^  @
 /X\ @
<___>@@
  ^  @
 /Y\ @
<___>@@
  ^  @
 /Z\ @
<___>@@
  ^  @
 /[\ @
<___>@@
  ^  @
 /\\ @
<___>@@
  ^  @
 /]\ @
<___>@@
  ^  @
 /^\ @
<___>@@
  ^  @
 /_\ @
<___>@@
  ^  @
 /`\ @
<___>@@
  ^  @
 /a\ @
<___>@@
  ^  @
 /b\ @
<___>@@
  ^  @
 /c\ @
<___>@@
  ^  @
 /d\ @
<___>@@
  ^  @
 /e\ @
<___>@@
  ^  @
 /f\ @
<___>@@
  ^  @
 /g\ @
<___>@@
  ^  @
 /h\ @
<___>@@
  ^  @
 /i\ @
<___>@@
  ^  @
 /j\ @
<___>@@
  ^  @
 /k\ @
<___>@@
  ^  @
 /l\ @
<___>@@
  ^  @
 /m\ @
<___>@@
  ^  @
 /n\ @
<___>@@
  ^  @
 /o\ @
<___>@@
  ^  @
 /p\ @
<___>@@
  ^  @
 /q\ @
<___>@@
  ^  @
 /r\ @
<___>@@
  ^  @
 /s\ @
<___>@@
  ^  @
 /t\ @
<___>@@
  ^  @
 /u\ @
<___>@@
  ^  @
 /v\ @
<___>@@
  ^  @
 /w\ @
<___>@@
  ^  @
 /x\ @
<___>@@
  ^  @
 /y\ @
<___>@@
  ^  @
 /z\ @
<___>@@
  ^  @
 /{\ @
<___>@@
  ^  @
 /|\ @
<___>@@
  ^  @
 /}\ @
<___>@@
  ^  @
 /~\ @
<___>@@
  ^  @
 /�\ @
<___>@@
  ^  @
 /�\ @
<___>@@
  ^  @
 /�\ @
<___>@@
  ^  @
 /�\ @
<___>@@
  ^  @
 /�\ @
<___>@@
  ^  @
 /�\ @
<___>@@
  ^  @
 /�\ @
<___>@@
128
  ^  @
 /�\ @
<___>@@
129
  ^  @
 /�\ @
<___>@@
130
  ^  @
 /�\ @
<___>@@
131
  ^  @
 /�\ @
<___>@@
132
  ^  @
 /�\ @
<___>@@
133
  ^  @
 /�\ @
<___>@@
134
  ^  @
 /�\ @
<___>@@
135
  ^  @
 /�\ @
<___>@@
136
  ^  @
 /�\ @
<___>@@
137
  ^  @
 /�\ @
<___>@@
138
  ^  @
 /�\ @
<___>@@
139
  ^  @
 /�\ @
<___>@@
140
  ^  @
 /�\ @
<___>@@
141
  ^  @
 /�\ @
<___>@@
142
  ^  @
 /�\ @
<___>@@
143
  ^  @
 /�\ @
<___>@@
144
  ^  @
 /�\ @
<___>@@
145
  ^  @
 /�\ @
<___>@@
146
  ^  @
 /�\ @
<___>@@
147
  ^  @
 /�\ @
<___>@@
148
  ^  @
 /�\ @
<___>@@
149
  ^  @
 /�\ @
<___>@@
150
  ^  @
 /�\ @
<___>@@
151
  ^  @
 /�\ @
<___>@@
152
  ^  @
 /�\ @
<___>@@
153
  ^  @
 /�\ @
<___>@@
154
  ^  @
 /�\ @
<___>@@
155
  ^  @
 /�\ @
<___>@@
156
  ^  @
 /�\ @
<___>@@
157
  ^  @
 /�\ @
<___>@@
158
  ^  @
 /�\ @
<___>@@
159
  ^  @
 /�\ @
<___>@@
160
  ^  @
 /�\ @
<___>@@
161
  ^  @
 /�\ @
<___>@@
162
  ^  @
 /�\ @
<___>@@
163
  ^  @
 /�\ @
<___>@@
164
  ^  @
 /�\ @
<___>@@
165
  ^  @
 /�\ @
<___>@@
166
  ^  @
 /�\ @
<___>@@
167
  ^  @
 /�\ @
<___>@@
168
  ^  @
 /�\ @
<___>@@
169
  ^  @
 /�\ @
<___>@@
170
  ^  @
 /�\ @
<___>@@

171
  ^  @
 /�\ @
<___>@@
172
  ^  @
 /�\ @
<___>@@
173
  ^  @
 /�\ @
<___>@@
174
  ^  @
 /�\ @
<___>@@
175
  ^  @
 /�\ @
<___>@@
176    
  ^  @
 /�\ @
<___>@@
177
  ^  @
 /�\ @
<___>@@
178
  ^  @
 /�\ @
<___>@@
179
  ^  @
 /�\ @
<___>@@
180
  ^  @
 /�\ @
<___>@@
181
  ^  @
 /�\ @
<___>@@
182
  ^  @
 /�\ @
<___>@@
183
  ^  @
 /�\ @
<___>@@
184
  ^  @
 /�\ @
<___>@@
185
  ^  @
 /�\ @
<___>@@
186
  ^  @
 /�\ @
<___>@@
187
  ^  @
 /�\ @
<___>@@
188
  ^  @
 /�\ @
<___>@@
189
  ^  @
 /�\ @
<___>@@
190
  ^  @
 /�\ @
<___>@@
191
  ^  @
 /�\ @
<___>@@
192
  ^  @
 /�\ @
<___>@@
193
  ^  @
 /�\ @
<___>@@
194
  ^  @
 /�\ @
<___>@@
195
  ^  @
 /�\ @
<___>@@
196
  ^  @
 /�\ @
<___>@@
197
  ^  @
 /�\ @
<___>@@
198
  ^  @
 /�\ @
<___>@@
199
  ^  @
 /�\ @
<___>@@
200
  ^  @
 /�\ @
<___>@@
201
  ^  @
 /�\ @
<___>@@
202
  ^  @
 /�\ @
<___>@@
203
  ^  @
 /�\ @
<___>@@
204
  ^  @
 /�\ @
<___>@@
205
  ^  @
 /�\ @
<___>@@
206
  ^  @
 /�\ @
<___>@@
207
  ^  @
 /�\ @
<___>@@
208
  ^  @
 /�\ @
<___>@@
209
  ^  @
 /�\ @
<___>@@
210    
  ^  @
 /�\ @
<___>@@
211
  ^  @
 /�\ @
<___>@@
212
  ^  @
 /�\ @
<___>@@
213
  ^  @
 /�\ @
<___>@@
214
  ^  @
 /�\ @
<___>@@
215
  ^  @
 /�\ @
<___>@@
216       
  ^  @
 /�\ @
<___>@@
217
  ^  @
 /�\ @
<___>@@
218
  ^  @
 /�\ @
<___>@@
219
  ^  @
 /�\ @
<___>@@
220
  ^  @
 /�\ @
<___>@@
221
  ^  @
 /�\ @
<___>@@
222
  ^  @
 /�\ @
<___>@@
223
  ^  @
 /�\ @
<___>@@
224
  ^  @
 /�\ @
<___>@@
225
  ^  @
 /�\ @
<___>@@
226
  ^  @
 /�\ @
<___>@@
227
  ^  @
 /�\ @
<___>@@
228
  ^  @
 /�\ @
<___>@@
229
  ^  @
 /�\ @
<___>@@
230
  ^  @
 /�\ @
<___>@@
231
  ^  @
 /�\ @ 
<___>@@
232
  ^  @
 /�\ @
<___>@@
233
  ^  @
 /�\ @
<___>@@
234
  ^  @
 /�\ @
<___>@@
235       
  ^  @
 /�\ @
<___>@@
236
  ^  @
 /�\ @
<___>@@
237
  ^  @
 /�\ @
<___>@@
238
  ^  @
 /�\ @
<___>@@
239      
  ^  @
 /�\ @
<___>@@
240
  ^  @
 /\ @
<___>@@
241
  ^  @
 /�\ @
<___>@@
242
  ^  @
 /�\ @
<___>@@
243      
  ^  @
 /\ @
<___>@@
244
  ^  @
 /�\ @
<___>@@
245
  ^  @
 /\ @
<___>@@
246
  ^  @
 /�\ @
<___>@@
247
  ^  @
 /�\ @
<___>@@
248
  ^  @
 /�\ @
<___>@@
249
  ^  @
 /�\ @
<___>@@
250
  ^  @
 /�\ @
<___>@@
251
  ^  @
 /�\ @
<___>@@
252
  ^  @
 /�\ @
<___>@@
253
  ^  @
 /�\ @
<___>@@
254
  ^  @
 /�\ @
<___>@@
255
  ^  @
 /�\ @
<___>@@
";
}
