public partial class Figlet
{
    public string Caligraphy { get { return caligraphy; } }
    private string caligraphy = @"flf2a$ 21 19 30 -1 14
caligraphy.flf composed  by Vinney Thai <ssfiit@eris.cc.umb.edu>
caligraphy font (J, O, R) composed by Jorn <jorn@node.site.cat>
date: Oct 23, 1994

Explanation of first line:
flf2 - ""magic number"" for file identification
a    - should always be `a', for now
$    - the ""hardblank"" -- prints as a blank, but can't be smushed
21   - height of a character
19   - height of a character, not including descenders
20   - max line length (excluding comment lines) + a fudge factor
-1   - default smushmode for this font (like ""-m 0"" on command line)
15   - number of comment lines

$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@
$ $@@
  @
  @
  @
  @
  @
  @
  @
  @
  @
e$@
x$@
c$@
l$@
a$@
m$@
a$@
t$@
i$@
o$@
n$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
d$@
o$@
u$@
b$@
l$@
e$@
q$@
u$@
o$@
t$@
e$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
p$@
o$@
u$@
n$@
d$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
d$@
o$@
l$@
l$@
a$@
r$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
p$@
e$@
r$@
c$@
e$@
n$@
t$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
a$@
m$@
p$@
e$@
r$@
s$@
a$@
n$@
d$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
s$@
i$@
n$@
g$@
l$@
e$@
q$@
u$@
o$@
t$@
e$@
  @@
  @
  @
  @
  @
  @
  @
o$@
p$@
e$@
n$@
p$@
a$@
r$@
e$@
n$@
t$@
h$@
e$@
s$@
y$@
  @@
  @
  @
  @
  @
  @
c$@
l$@
o$@
s$@
e$@
p$@
a$@
r$@
e$@
n$@
t$@
h$@
e$@
s$@
y$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
a$@
s$@
t$@
e$@
r$@
i$@
s$@
t$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
p$@
l$@
u$@
s$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
c$@
o$@
m$@
m$@
a$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
m$@
i$@
n$@
u$@
s$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
p$@
e$@
r$@
i$@
o$@
d$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
s$@
l$@
a$@
s$@
h$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
0$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
1$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
2$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
3$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
4$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
5$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
6$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
7$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
8$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
n$@
u$@
m$@
b$@
e$@
r$@
9$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
c$@
o$@
l$@
o$@
n$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
s$@
e$@
m$@
i$@
c$@
o$@
l$@
o$@
n$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
l$@
e$@
s$@
s$@
e$@
r$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
e$@
q$@
u$@
a$@
l$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
g$@
r$@
e$@
a$@
t$@
e$@
r$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
q$@
u$@
e$@
s$@
t$@
i$@
o$@
n$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
a$@
t$@
  @@
                  @
        **$       @
     *****$       @
    *  ***$       @
       ***$       @
      *  **$      @
      *  **$      @
     *    **$     @
     *    **$     @
    *      **$    @
    *********$    @
   *        **$   @
   *        **$   @
  *****      **$  @
 *   ****    ** *$@
*     **      **$ @
*$                @
 **$              @
                  @
                  @
                  @@
                @
     ***** **$  @
  ******  ***$  @
 **   *  * **$  @
*    *  *  **$  @
    *  *   *$   @
   ** **  *$    @
   ** ** *$     @
   ** ***$      @
   ** ** ***$   @
   ** **   ***$ @
   *  **     **$@
      *      **$@
  ****     ***$ @
 *  ********$   @
*     ****$     @
*$              @
 **$            @
                @
                @
                @@
               @
      * ***$   @
    *  ****  *$@
   *  *  ****$ @
  *  **   **$  @
 *  ***$       @
**   **$       @
**   **$       @
**   **$       @
**   **$       @
**   **$       @
 **  **$       @
  ** *      *$ @
   ***     *$  @
    *******$   @
      ***$     @
               @
               @
               @
               @
               @@
                  @
      ***** **$   @
   ******  ***$   @
 **    *  * ***$  @
*     *  *   ***$ @
     *  *     ***$@
    ** **      **$@
    ** **      **$@
    ** **      **$@
    ** **      **$@
    ** **      **$@
    *  **      **$@
       *       *$ @
  *****       *$  @
 *   *********$   @
*       ****$     @
*$                @
 **$              @
                  @
                  @
                  @@
                 @
     ***** **$   @
  ******  **** *$@
 **   *  * ****$ @
*    *  *   **$  @
    *  *$        @
   ** **$        @
   ** **$        @
   ** ******$    @
   ** *****$     @
   ** **$        @
   *  **$        @
      *$         @
  ****         *$@
 *  ***********$ @
*     ******$    @
*$               @
 **$             @
                 @
                 @
                 @@
                 @
     ***** **$   @
  ******  **** *$@
 **   *  *  ***$ @
*    *  *    *$  @
    *  *$        @
   ** **$        @
   ** **$        @
   ** ******$    @
   ** *****$     @
   ** **$        @
   *  **$        @
      *$         @
  *****$         @
 *  *****$       @
*    ***$        @
*$               @
 **$             @
                 @
                 @
                 @@
                 @
      * ***$     @
    *  ****  *$  @
   *  *  ****$   @
  *  **   **$    @
 *  ***$         @
**   **$         @
**   **   ***$   @
**   **  ****  *$@
**   ** *  ****$ @
**   ***    **$  @
 **  **     *$   @
  ** *      *$   @
   ***     *$    @
    *******$     @
      ***$       @
                 @
                 @
                 @
                 @
                 @@
                    @
     *****    **$   @
  ******  *  **** *$@
 **   *  *   *****$ @
*    *  *    * *$   @
    *  *     *$     @
   ** **     *$     @
   ** **     *$     @
   ** ********$     @
   ** **     *$     @
   ** **     **$    @
   *  **     **$    @
      *       **$   @
  ****        **$   @
 *  *****      **$  @
*     **$           @
*$                  @
 **$                @
                    @
                    @
                    @@
                 @
        *****  *$@
     ******  *$  @
    **   *  *$   @
   *    *  *$    @
       *  *$     @
      ** **$     @
      ** **$     @
    **** **$     @
   * *** **$     @
      ** **$     @
 **   ** **$     @
***   *  *$      @
 ***    *$       @
  ******$        @
    ***$         @
                 @
                 @
                 @
                 @
                 @@
                    @
        ***** **$   @
     ******  **** *$@
    **   *  * ****$ @
   *    *  *   **$  @
       *  *$        @
      ** **$        @
      ** **$        @
    **** **$        @
   * *** **$        @
      ** **$        @
      ** **$        @
      ** **$        @
      ** **$        @
      *  *$         @
  **     *$         @
 ****   *$          @
 *  * **$           @
*    **$            @
     *$             @
                    @@
                        @
     *****$             @
  ******$               @
 **   *  *    **$       @
*    *  *   **** *$     @
    *  *     ****$      @
   ** **    * **$       @
   ** **   *$           @
   ** *****$            @
   ** ** ***$           @
   ** **   ***$         @
   *  **    ***$        @
      *       ***$      @
  ****         ***$     @
 *  *****        ***  *$@
*    ***           ***$ @
*$                      @
 **$                    @
                        @
                        @
                        @@
                   @
     ***** *$      @
  ******  *$       @
 **   *  *$        @
*    *  *$         @
    *  *$          @
   ** **$          @
   ** **$          @
   ** **$          @
   ** **$          @
   ** **$          @
   *  **$          @
      *$           @
  ****           *$@
 *  *************$ @
*     *********$   @
*$                 @
 **$               @
                   @
                   @
                   @@
                        @
     *****   **    **$  @
  ******  ***** *****$  @
 **   *  *  ***** *****$@
*    *  *   * **  * **$ @
    *  *    *     *$    @
   ** **    *     *$    @
   ** **    *     *$    @
   ** **    *     *$    @
   ** **    *     *$    @
   ** **    *     **$   @
   *  **    *     **$   @
      *     *      **$  @
  ****      *      **$  @
 *  *****           **$ @
*     **$               @
*$                      @
 **$                    @
                        @
                        @
                        @@
                       @
     ***** *     **$   @
  ******  **    **** *$@
 **   *  * **    ****$ @
*    *  *  **    * *$  @
    *  *    **   *$    @
   ** **    **   *$    @
   ** **     **  *$    @
   ** **     **  *$    @
   ** **      ** *$    @
   ** **      ** *$    @
   *  **       ***$    @
      *        ***$    @
  ****          **$    @
 *  *****$             @
*     **$              @
*$                     @
 **$                   @
                       @
                       @
                       @@
               @
      * ***$   @
    *  ****$   @
   *  *  ***$  @
  *  **   ***$ @
 *  ***    ***$@
**   **     **$@
**   **     **$@
**   **     **$@
**   **     **$@
**   **     **$@
 **  **     **$@
  ** *      *$ @
   ***     *$  @
    *******$   @
      ***$     @
               @
               @
               @
               @
               @@
                    @
        ***** **$   @
     ******  ****$  @
    **   *  *  ***$ @
   *    *  *    ***$@
       *  *      **$@
      ** **      **$@
      ** **      **$@
    **** **      *$ @
   * *** **     *$  @
      ** *******$   @
      ** ******$    @
      ** **$        @
      ** **$        @
      ** **$        @
 **   ** **$        @
***   *  *$         @
 ***    *$          @
  ******$           @
    ***$            @
                    @@
               @
      * ***$   @
    *  ****$   @
   *  *  ***$  @
  *  **   ***$ @
 *  ***    ***$@
**   **     **$@
**   **     **$@
**   **     **$@
**   **     **$@
**   **     **$@
 **  ** *** **$@
  ** *   ****$ @
   ***     ***$@
    ******* **$@
      ***   **$@
            **$@
            *$ @
           *$  @
          *$   @
               @@
                @
     ***** ***$ @
  ******  * **$ @
 **   *  *  **$ @
*    *  *   **$ @
    *  *    *$  @
   ** **   *$   @
   ** **  *$    @
   ** ****$     @
   ** **  ***$  @
   ** **    **$ @
   *  **    **$ @
      *     **$ @
  ****      ***$@
 *  ****    **$ @
*    **     *$  @
*$              @
 **$            @
                @
                @
                @@
                 @
      *******$   @
    *       ***$ @
   *         **$ @
   **        *$  @
    ***$         @
   ** ***$       @
    *** ***$     @
      *** ***$   @
        *** ***$ @
          ** ***$@
           ** **$@
            * *$ @
  ***        *$  @
 *  *********$   @
*     *****$     @
*$               @
 **$             @
                 @
                 @
                 @@
                   @
  ****           *$@
 *  *************$ @
*     *********$   @
*     *  *$        @
 **  *  **$        @
    *  ***$        @
   **   **$        @
   **   **$        @
   **   **$        @
   **   **$        @
    **  **$        @
     ** *      *$  @
      ***     *$   @
       *******$    @
         ***$      @
                   @
                   @
                   @
                   @
                   @@
                     @
     ***** *    **$  @
  ******  *  *****$  @
 **   *  *     *****$@
*    *  **     * **$ @
    *  ***     *$    @
   **   **     *$    @
   **   **     *$    @
   **   **     *$    @
   **   **     *$    @
   **   **     *$    @
    **  **     *$    @
     ** *      *$    @
      ***      *$    @
       ********$     @
         ****$       @
                     @
                     @
                     @
                     @
                     @@
                       @
     ***** *      **$  @
  ******  *    *****$  @
 **   *  *       *****$@
*    *  **       * **$ @
    *  ***      *$     @
   **   **      *$     @
   **   **      *$     @
   **   **     *$      @
   **   **     *$      @
   **   **     *$      @
    **  **    *$       @
     ** *     *$       @
      ***     *$       @
       *******$        @
         ***$          @
                       @
                       @
                       @
                       @
                       @@
                            @
     ***** *    **   ***$   @
  ******  *  *****    ***$  @
 **   *  *     *****   ***$ @
*    *  **     * **      **$@
    *  ***     *         **$@
   **   **     *         **$@
   **   **     *         **$@
   **   **     *         **$@
   **   **     *         **$@
   **   **     *         **$@
    **  **     *         **$@
     ** *      *         *$ @
      ***      ***      *$  @
       ******** ********$   @
         ****     ****$     @
                            @
                            @
                            @
                            @
                            @@
                      @
  ***          **$    @
 *****       ****  *$ @
*   ***      ******$  @
     ***    *   **$   @
      ***  *$         @
       ****$          @
        ***$          @
        ****$         @
       *  ***$        @
      *    ***$       @
     *      ***$      @
    *        ***$     @
   *          ***   *$@
  *            *****$ @
 *              ***$  @
                      @
                      @
                      @
                      @
                      @@
                      @
      ***** *    **$  @
   ******  *  *****$  @
  **   *  *     *****$@
 *    *  **     * **$ @
     *  ***     *$    @
    **   **     *$    @
    **   **     *$    @
    **   **     *$    @
    **   **     *$    @
    **   **     *$    @
     **  **     *$    @
      ** *      *$    @
       ***      *$    @
        *********$    @
          **** ***$   @
                ***$  @
    ********     ***$ @
  *************  **$  @
 *           ****$    @
                      @@
                   @
  ****           *$@
 *  *************$ @
*     **********$  @
*             *$   @
 **          *$    @
            *$     @
           *$      @
          *$       @
         *$        @
        *$         @
       *$          @
      *$           @
  ****           *$@
 *  *************$ @
*     **********$  @
                   @
                   @
                   @
                   @
                   @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
l$@
e$@
f$@
t$@
b$@
r$@
a$@
c$@
k$@
e$@
t$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
b$@
a$@
c$@
k$@
s$@
l$@
a$@
s$@
h$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
r$@
i$@
g$@
h$@
t$@
b$@
r$@
a$@
c$@
k$@
e$@
t$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
c$@
a$@
r$@
e$@
t$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
u$@
n$@
d$@
e$@
r$@
s$@
c$@
o$@
r$@
e$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
l$@
e$@
f$@
t$@
q$@
u$@
o$@
t$@
e$@
  @@
           @
           @
           @
           @
           @
           @
   ****$   @
  * ***  *$@
 *   ****$ @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
 ***** **$ @
  ***   **$@
           @
           @
           @
           @
           @@
           @
  *$       @
**$        @
**$        @
**$        @
**$        @
** ****$   @
*** ***  *$@
**   ****$ @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
 *****$    @
  ***$     @
           @
           @
           @
           @
           @@
           @
           @
           @
           @
           @
           @
   ****$   @
  * ***  *$@
 *   ****$ @
**$        @
**$        @
**$        @
**$        @
***     *$ @
 *******$  @
  *****$   @
           @
           @
           @
           @
           @@
           @
     **$   @
      **$  @
      **$  @
      **$  @
      **$  @
  *** **$  @
 *********$@
**   ****$ @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
 *****$    @
  ***$     @
           @
           @
           @
           @
           @@
          @
          @
          @
          @
          @
          @
   ***$   @
  * ***$  @
 *   ***$ @
**    ***$@
********$ @
*******$  @
**$       @
****    *$@
 *******$ @
  *****$  @
          @
          @
          @
          @
          @@
         @
   ***$  @
 ** ***$ @
**   ***$@
**$      @
**$      @
******$  @
*****$   @
**$      @
**$      @
**$      @
**$      @
**$      @
**$      @
**$      @
 **$     @
         @
         @
         @
         @
         @@
              @
              @
              @
              @
              @
              @
    ****$     @
   *  ***  *$ @
  *    ****$  @
 **     **$   @
 **     **$   @
 **     **$   @
 **     **$   @
 **     **$   @
  ********$   @
    *** ***$  @
         ***$ @
   ****   ***$@
 *******  **$ @
*     ****$   @
              @@
          @
  *$      @
**$       @
**$       @
**$       @
**$       @
**  ***$  @
** * ***$ @
***   ***$@
**     **$@
**     **$@
**     **$@
**     **$@
**     **$@
**     **$@
 **    **$@
       *$ @
      *$  @
     *$   @
    *$    @
          @@
        @
        @
  *$    @
 ***$   @
  *$    @
        @
***$    @
 ***$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  *** *$@
   ***$ @
        @
        @
        @
        @
        @@
       @
       @
  *$   @
 ***$  @
  *$   @
       @
***$   @
 ***$  @
  **$  @
  *$   @
 *$    @
***$   @
 ***$  @
  ***$ @
   ***$@
    **$@
    **$@
    *$ @
   *$  @
  *$   @
       @@
           @
  *$       @
**$        @
**$        @
**$        @
**$        @
**  ***$   @
** * ***$  @
***   *$   @
**   *$    @
**  *$     @
** **$     @
******$    @
**  ***$   @
**   *** *$@
 **   ***$ @
           @
           @
           @
           @
           @@
        @
***$    @
 ***$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  **$   @
  *** *$@
   ***$ @
        @
        @
        @
        @
        @@
                 @
                 @
                 @
                 @
                 @
                 @
*** **** ****$   @
 *** **** ***  *$@
  **  **** ****$ @
  **   **   **$  @
  **   **   **$  @
  **   **   **$  @
  **   **   **$  @
  **   **   **$  @
  ***  ***  ***$ @
   ***  ***  ***$@
                 @
                 @
                 @
                 @
                 @@
             @
             @
             @
             @
             @
             @
***  ****$   @
 **** **** *$@
  **   ****$ @
  **    **$  @
  **    **$  @
  **    **$  @
  **    **$  @
  **    **$  @
  ***   ***$ @
   ***   ***$@
             @
             @
             @
             @
             @@
           @
           @
           @
           @
           @
   ****$   @
  * ***  *$@
 *   ****$ @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
 ******$   @
  ****$    @
           @
           @
           @
           @
           @
           @@
           @
           @
           @
           @
           @
   ****$   @
  * ***  *$@
 *   ****$ @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
*******$   @
******$    @
**$        @
**$        @
**$        @
 **$       @
           @
           @@
           @
           @
           @
           @
           @
   ****$   @
  * ***  *$@
 *   ****$ @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
**    **$  @
 *******$  @
  ******$  @
      **$  @
      **$  @
      **$  @
       **$ @
           @
           @@
             @
             @
             @
             @
             @
***  ****$   @
 **** **** *$@
  **   ****$ @
  **$        @
  **$        @
  **$        @
  **$        @
  **$        @
  ***$       @
   ***$      @
             @
             @
             @
             @
             @
             @@
           @
           @
           @
           @
           @
   ****$   @
  * **** *$@
 **  ****$ @
****$      @
  ***$     @
    ***$   @
      ***$ @
 ****  **$ @
* **** *$  @
   ****$   @
           @
           @
           @
           @
           @
           @@
          @
          @
    *$    @
   **$    @
   **$    @
 ********$@
********$ @
   **$    @
   **$    @
   **$    @
   **$    @
   **$    @
   **$    @
   **$    @
    **$   @
          @
          @
          @
          @
          @
          @@
              @
              @
              @
              @
              @
**   ****$    @
 **    ***  *$@
 **     ****$ @
 **      **$  @
 **      **$  @
 **      **$  @
 **      **$  @
 **      **$  @
  ******* **$ @
   *****   **$@
              @
              @
              @
              @
              @
              @@
             @
             @
             @
**$          @
**$          @
 **    ***$  @
  **    ***$ @
  **     ***$@
  **      **$@
  **      **$@
  **      **$@
  **      **$@
  **      *$ @
   *******$  @
    *****$   @
             @
             @
             @
             @
             @
             @@
                       @
                       @
                       @
**$                    @
**$                    @
 **    ***    ****$    @
  **    ***     ***  *$@
  **     ***     ****$ @
  **      **      **$  @
  **      **      **$  @
  **      **      **$  @
  **      **      **$  @
  **      **      *$   @
   ******* *******$    @
    *****   ***** $    @
                       @
                       @
                       @
                       @
                       @
                       @@
               @
               @
               @
               @
               @
 ***    ***$   @
* ***  **** *$ @
   *** *****$  @
    ***  **$   @
     ***$      @
    * ***$     @
   *   ***$    @
  *     ***$   @
 *       *** *$@
*         ***$ @
               @
               @
               @
               @
               @
               @@
               @
               @
               @
               @
               @
**   ****$     @
 **    ***  *$ @
 **     ****$  @
 **      **$   @
 **      **$   @
 **      **$   @
 **      **$   @
 **      **$   @
  *********$   @
    **** ***$  @
          ***$ @
   *****   ***$@
 ********  **$ @
*      ****$   @
               @
               @@
           @
           @
           @
           @
           @
  ******$  @
 ********$ @
*      **$ @
       *$  @
      *$   @
     ***$  @
      ***$ @
       ***$@
        **$@
        **$@
        *$ @
       *$  @
      *$   @
     *$    @
           @
           @@
  @
  @
  @
  @
l$@
e$@
f$@
t$@
c$@
u$@
r$@
l$@
y$@
b$@
r$@
a$@
c$@
k$@
e$@
t$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
p$@
i$@
p$@
e$@
  @@
  @
  @
  @
r$@
i$@
g$@
h$@
t$@
c$@
r$@
u$@
l$@
y$@
b$@
r$@
a$@
c$@
k$@
e$@
t$@
  @@
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
  @
t$@
i$@
d$@
l$@
e$@
  @@
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @@
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @@
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @@
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @@
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @@
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @@
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @
 @@
";
}
