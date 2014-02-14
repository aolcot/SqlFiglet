public partial class Figlet
{
    public string Alphabet { get { return alphabet; } }
    private string alphabet = @"flf2a 7 5 10 -1 12
Alphabet by Wendell Hicken 11/93 (whicken@parasoft.com)

Explanation of first line:
flf2 - ""magic number"" for file identification
a    - should always be `a', for now
$    - the ""hardblank"" -- prints as a blank, but can't be smushed
6    - height of a character
5    - height of a character, not including descenders
20   - max line length (excluding comment lines) + a fudge factor
15   - default smushmode for this font (like ""-m 15"" on command line)
12   - number of comment lines

@
@
@
@
@
@
@@
!!! @
!!! @
!!! @
    @
!!! @
    @
    @@
'' '' @
'' '' @
      @
      @
      @
      @
      @@
 # #  @
##### @
 # #  @
##### @
 # #  @
      @
      @@
  $ $   @
 $$$$$  @
$ $ $   @
 $$$$$  @
  $ $ $ @
 $$$$$  @
  $ $   @@
%   %% @
   %%  @
  %%   @
 %%    @
%%   % @
       @
       @@
 &&   @
&  &  @
 &&& &@
& & & @
 &&&& @
      @
      @@
'' @
'' @
   @
   @
   @
   @
   @@
 (( @
((  @
((  @
((  @
 (( @
    @
    @@
))  @
 )) @
 )) @
 )) @
))  @
    @
    @@
      @
* * * @
 ***  @
***** @
 ***  @
* * * @
      @@
    @
 +  @
+++ @
 +  @
    @
    @
    @@
   @
   @
   @
   @
,, @
 , @
   @@
    @
    @
--- @
    @
    @
    @
    @@
   @
   @
   @
.. @
.. @
   @
   @@
    //@
   // @
  //  @
 //   @
//    @
      @
      @@
 000  @
0  00 @
0 0 0 @
00  0 @
 000  @
      @
      @@
 11  @
111  @
 11  @
 11  @
11l1 @
     @
     @@
 22  @
2  2 @
  2  @
 2   @
2222 @
     @
     @@
333  @
   3 @
 33  @
   3 @
333  @
     @
     @@
4  4 @
4  4 @
4444 @
   4 @
   4 @
     @
     @@
5555 @
5    @
555  @
   5 @
555  @
     @
     @@
  6   @
 6    @
6666  @
6   6 @
 666  @
      @
      @@
77777 @
   7  @
  7   @
  7   @
  7   @
      @
      @@
 888  @
8   8 @
 888  @
8   8 @
 888  @
      @
      @@
 9999 @
9   9 @
 9999 @
   9  @
  9   @
      @
      @@
   @
:: @
   @
:: @
   @
   @
   @@
   @
;; @
   @
;; @
 ; @
   @
   @@
  << @
 <<  @
<<   @
 <<  @
  << @
     @
     @@
    @
=== @
    @
=== @
    @
    @
    @@
>>   @
 >>  @
  >> @
 >>  @
>>   @
     @
     @@
 ???  @
?   ? @
   ?  @
  ?   @
  ?   @
      @
      @@
 @@@  @
@   @ @
@  @@ @
@     @
 @@@  @
      @
      @@
 AA  @
A  A @
AAAA @
A  A @
A  A @
     @
     @@
BBBB  @
B   B @
BBBB  @
B   B @
BBBB  @
      @
      @@
 CCC @
C    @
C    @
C    @
 CCC @
     @
     @@
DDD  @
D  D @
D  D @
D  D @
DDD  @
     @
     @@
EEEE @
E    @
EEE  @
E    @
EEEE @
     @
     @@
FFFF @
F    @
FFF  @
F    @
F    @
     @
     @@
 GGG  @
G     @
G  GG @
G   G @
 GGG  @
      @
      @@
H  H @
H  H @
HHHH @
H  H @
H  H @
     @
     @@
III @
 I  @
 I  @
 I  @
III @
    @
    @@
    J @
    J @
    J @
J   J @
 JJJ  @
      @
      @@
K  K @
K K  @
KK   @
K K  @
K  K @
     @
     @@
L    @
L    @
L    @
L    @
LLLL @
     @
     @@
M   M @
MM MM @
M M M @
M   M @
M   M @
      @
      @@
N   N @
NN  N @
N N N @
N  NN @
N   N @
      @
      @@
 OOO  @
O   O @
O   O @
O   O @
 OOO  @
      @
      @@
PPPP  @
P   P @
PPPP  @
P     @
P     @
      @
      @@
 QQQ   @
Q   Q  @
Q   Q  @
Q  QQ  @
 QQQQ  @
     Q @
       @@
RRRR  @
R   R @
RRRR  @
R R   @
R  RR @
      @
      @@
 SSS  @
S     @
 SSS  @
    S @
SSSS  @
      @
      @@
TTTTTT @
  TT   @
  TT   @
  TT   @
  TT   @
       @
       @@
U   U @
U   U @
U   U @
U   U @
 UUU  @
      @
      @@
V     V @
V     V @
 V   V  @
  V V   @
   V    @
        @
        @@
W     W @
W     W @
W  W  W @
 W W W  @
  W W   @
        @
        @@
X   X @
 X X  @
  X   @
 X X  @
X   X @
      @
      @@
Y   Y @
 Y Y  @
  Y   @
  Y   @
  Y   @
      @
      @@
ZZZZZ @
   Z  @
  Z   @
 Z    @
ZZZZZ @
      @
      @@
[[[[ @
[[   @
[[   @
[[   @
[[[[ @
     @
     @@
\\    @
 \\   @
  \\  @
   \\ @
    \\@
      @
      @@
]]]] @
  ]] @
  ]] @
  ]] @
]]]] @
     @
     @@
 ^^  @
^  ^ @
     @
     @
     @
     @
     @@
    @
    @
    @
    @
____@
____@
    @@
`` @
   @
   @
   @
   @
   @
   @@
    @
    @
 aa @
a a @
aaa @
    @
    @@
b    @
b    @
bbb  @
b  b @
bbb  @
     @
     @@
     @
     @
 ccc @
c    @
 ccc @
     @
     @@
   d @
   d @
 ddd @
d  d @
 ddd @
     @
     @@
    @
    @
eee @
e e @
ee  @
    @
    @@
 ff @
 f  @
fff @
 f  @
 f  @
    @
    @@
    @
    @
ggg @
g g @
ggg @
  g @
ggg @@
h    @
h    @
hhh  @
h  h @
h  h @
     @
     @@
   @
ii @
   @
ii @
ii @
   @
   @@
     @
   j @
     @
   j @
   j @
j  j @
 jj  @@
k    @
k k  @
kk   @
k k  @
k  k @
     @
     @@
l @
l @
l @
l @
l @
  @
  @@
      @
      @
mmmm  @
m m m @
m m m @
      @
      @@
     @
     @
nnn  @
n  n @
n  n @
     @
     @@
    @
    @
ooo @
o o @
ooo @
    @
    @@
     @
     @
ppp  @
p  p @
ppp  @
p    @
p    @@
      @
      @
 qqq  @
q  q  @
 qqq  @
   q  @
   qq @@
    @
    @
rrr @
r   @
r   @
    @
    @@
    @
    @
 ss @
 s  @
ss  @
    @
    @@
 t  @
 t  @
ttt @
 t  @
 tt @
    @
    @@
     @
     @
u  u @
u  u @
 uuu @
     @
     @@
    @
    @
v v @
v v @
 v  @
    @
    @@
      @
      @
w   w @
w w w @
 w w  @
      @
      @@
    @
    @
x x @
 x  @
x x @
    @
    @@
     @
     @
y  y @
y  y @
 yyy @
   y @
yyy  @@
    @
    @
zz  @
 z  @
 zz @
    @
    @@
  {{ @
 {{  @
{{   @
 {{  @
  {{ @
     @
     @@
||@
||@
||@
||@
||@
||@
  @@
}}   @
 }}  @
  }} @
 }}  @
}}   @
     @
     @@
     @
 ~ ~ @
~ ~  @
     @
     @
     @
     @@
o  o @
 AA  @
A  A @
AAAA @
A  A @
     @
     @@
o   o @
 OOO  @
O   O @
O   O @
 OOO  @
      @
      @@
o   o @
U   U @
U   U @
U   U @
 UUU  @
      @
      @@
o o @
    @
 aa @
a a @
aaa @
    @
    @@
o o @
    @
ooo @
o o @
ooo @
    @
    @@
o  o @
     @
u  u @
u  u @
 uuu @
     @
     @@
BBBB  @
B   B @
BBBB  @
B   B @
BBBB  @
B     @
      @@
";
}
