¡
YF:\Temp\SonarQube\SonarQubeTest\WebApplication1\WebApplication1\App_Start\BundleConfig.cs
	namespace 	
WebApplication1
 
{ 
public 

class 
BundleConfig 
{ 
public		 
static		 
void		 
RegisterBundles		 *
(		* +
BundleCollection		+ ;
bundles		< C
)		C D
{

 	
bundles 
. 
Add 
( 
new 
ScriptBundle (
(( )
$str) ;
); <
.< =
Include= D
(D E
$str 7
)7 8
)8 9
;9 :
bundles 
. 
Add 
( 
new 
ScriptBundle (
(( )
$str) >
)> ?
.? @
Include@ G
(G H
$str 4
)4 5
)5 6
;6 7
bundles 
. 
Add 
( 
new 
ScriptBundle (
(( )
$str) >
)> ?
.? @
Include@ G
(G H
$str /
)/ 0
)0 1
;1 2
bundles 
. 
Add 
( 
new 
ScriptBundle (
(( )
$str) >
)> ?
.? @
Include@ G
(G H
$str .
). /
)/ 0
;0 1
bundles 
. 
Add 
( 
new 
StyleBundle '
(' (
$str( 7
)7 8
.8 9
Include9 @
(@ A
$str /
,/ 0
$str *
)* +
)+ ,
;, -
} 	
} 
} ã
YF:\Temp\SonarQube\SonarQubeTest\WebApplication1\WebApplication1\App_Start\FilterConfig.cs
	namespace 	
WebApplication1
 
{ 
public 

class 
FilterConfig 
{ 
public 
static 
void !
RegisterGlobalFilters 0
(0 1"
GlobalFilterCollection1 G
filtersH O
)O P
{		 	
filters

 
.

 
Add

 
(

 
new

  
HandleErrorAttribute

 0
(

0 1
)

1 2
)

2 3
;

3 4
} 	
} 
} È
XF:\Temp\SonarQube\SonarQubeTest\WebApplication1\WebApplication1\App_Start\RouteConfig.cs
	namespace 	
WebApplication1
 
{		 
public

 

class

 
RouteConfig

 
{ 
public 
static 
void 
RegisterRoutes )
() *
RouteCollection* 9
routes: @
)@ A
{ 	
routes 
. 
IgnoreRoute 
( 
$str ;
); <
;< =
routes 
. 
MapRoute 
( 
name 
: 
$str 
,  
url 
: 
$str 1
,1 2
defaults 
: 
new 
{ 

controller  *
=+ ,
$str- 3
,3 4
action5 ;
=< =
$str> E
,E F
idG I
=J K
UrlParameterL X
.X Y
OptionalY a
}b c
) 
; 
} 	
} 
} ù/
]F:\Temp\SonarQube\SonarQubeTest\WebApplication1\WebApplication1\Controllers\HomeController.cs
	namespace 	
WebApplication1
 
. 
Controllers %
{		 
public

 

class

 
HomeController

 
:

  !

Controller

" ,
{ 
private 
static 
string 
_fileBasePath +
=, -
BuildFilePathSetUp. @
(@ A
)A B
.B C
StartingPathC O
;O P
public 
ActionResult 
Index !
(! "
)" #
{ 	
return 
View 
( 
) 
; 
} 	
public 
ActionResult 
About !
(! "
)" #
{ 	
ViewBag 
. 
Message 
= 
$str B
;B C
return 
View 
( 
) 
; 
} 	
public 
ActionResult 
Contact #
(# $
)$ %
{ 	
ViewBag 
. 
Message 
= 
$str 2
;2 3
JObject 
jObject 
= 
GetSessionData +
(+ ,
$str, 0
)0 1
;1 2
ViewBag   
.   
jObject   
=   
jObject   %
;  % &
return"" 
View"" 
("" 
)"" 
;"" 
}## 	
private%% 
JObject%% 
GetSessionData%% &
(%%& '
string%%' -
	sessionID%%. 7
)%%7 8
{&& 	
JObject'' 
o2'' 
='' 
new'' 
JObject'' $
(''$ %
)''% &
;''& '
string(( 
path(( 
=(( +
GetSaveMolecularSessionDataPath(( 9
(((9 :
)((: ;
+((< =
Path((> B
.((B C"
DirectorySeparatorChar((C Y
+((Z [
	sessionID((\ e
+((f g
$str((h o
;((o p
var)) 
filePath)) 
=)) 
Path)) 
.))  
GetFullPath))  +
())+ ,
Path)), 0
.))0 1
Combine))1 8
())8 9
path))9 =
)))= >
)))> ?
;))? @
if++ 
(++ 
!++ 
filePath++ 
.++ 

StartsWith++ $
(++$ %
Path++% )
.++) *
GetFullPath++* 5
(++5 6
_fileBasePath++6 C
)++C D
,++D E
StringComparison++F V
.++V W
Ordinal++W ^
)++^ _
)++_ `
{,, 
throw-- 
new-- '
UnauthorizedAccessException-- 5
(--5 6
)--6 7
;--7 8
}.. 
else// 
{00 
FileInfo11 
ContentPath11 $
=11% &
new11' *
FileInfo11+ 3
(113 4
Path114 8
.118 9
GetFullPath119 D
(11D E
filePath11E M
)11M N
)11N O
;11O P
if33 
(33 
ContentPath33 
.33  
Exists33  &
)33& '
{44 
var55 
fs55 
=55 
new55  

FileStream55! +
(55+ ,
Path55, 0
.550 1
GetFullPath551 <
(55< =
filePath55= E
)55E F
,55F G
FileMode55H P
.55P Q
Open55Q U
,55U V

FileAccess55W a
.55a b
Read55b f
,55f g
	FileShare55h q
.55q r
	ReadWrite55r {
)55{ |
;55| }
using77 
(77 
var77 
sr77 !
=77" #
new77$ '
StreamReader77( 4
(774 5
fs775 7
)777 8
)778 9
{88 
using99 
(99 
JsonTextReader99 -
reader99. 4
=995 6
new997 :
JsonTextReader99; I
(99I J
sr99J L
)99L M
)99M N
{:: 
o2;; 
=;;  
(;;! "
JObject;;" )
);;) *
JToken;;* 0
.;;0 1
ReadFrom;;1 9
(;;9 :
reader;;: @
);;@ A
;;;A B
}<< 
}== 
}>> 
}?? 
returnAA 
o2AA 
;AA 
}BB 	
privateDD 
stringDD +
GetSaveMolecularSessionDataPathDD 6
(DD6 7
)DD7 8
{EE 	
stringFF 
DateFolderNameFF !
=FF" #
DateTimeFF$ ,
.FF, -
UtcNowFF- 3
.FF3 4
ToStringFF4 <
(FF< =
$strFF= G
)FFG H
;FFH I
returnHH 
PathHH 
.HH 
GetFullPathHH #
(HH# $
PathHH$ (
.HH( )
CombineHH) 0
(HH0 1
_fileBasePathHH1 >
,HH> ?
$strHH@ O
+HHP Q
ConvertHHR Y
.HHY Z
ToInt32HHZ a
(HHa b
SessionHHb i
[HHi j
$strHHj z
]HHz {
)HH{ |
+HH} ~
$str	HH õ
+
HHú ù
DateFolderName
HHû ¨
+
HH≠ Æ
$str
HHØ ∫
)
HH∫ ª
)
HHª º
;
HHº Ω
}II 	
privateKK 
staticKK 
FilePathSetupKK $
BuildFilePathSetUpKK% 7
(KK7 8
)KK8 9
{LL 	
varMM 
filePathModelMM 
=MM 
newMM  #
FilePathSetupMM$ 1
(MM1 2
)MM2 3
;MM3 4
filePathModelOO 
.OO 
StartingPathOO &
=OO' (
$strOO) 9
;OO9 :
returnQQ 
filePathModelQQ  
;QQ  !
}RR 	
}SS 
}TT ¸
NF:\Temp\SonarQube\SonarQubeTest\WebApplication1\WebApplication1\Global.asax.cs
	namespace		 	
WebApplication1		
 
{

 
public 

class 
MvcApplication 
:  !
System" (
.( )
Web) ,
., -
HttpApplication- <
{ 
	protected 
void 
Application_Start (
(( )
)) *
{ 	
AreaRegistration 
. 
RegisterAllAreas -
(- .
). /
;/ 0
FilterConfig 
. !
RegisterGlobalFilters .
(. /
GlobalFilters/ <
.< =
Filters= D
)D E
;E F
RouteConfig 
. 
RegisterRoutes &
(& '

RouteTable' 1
.1 2
Routes2 8
)8 9
;9 :
BundleConfig 
. 
RegisterBundles (
(( )
BundleTable) 4
.4 5
Bundles5 <
)< =
;= >
} 	
} 
} æ
WF:\Temp\SonarQube\SonarQubeTest\WebApplication1\WebApplication1\Models\FilePathSetup.cs
	namespace 	
WebApplication1
 
. 
Models  
{ 
public 

class 
FilePathSetup 
{		 
public

 
string

 
StartingPath

 "
=

# $
string

% +
.

+ ,
Empty

, 1
;

1 2
} 
} Ö
ZF:\Temp\SonarQube\SonarQubeTest\WebApplication1\WebApplication1\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str *
)* +
]+ ,
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str ,
), -
]- .
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
["" 
assembly"" 	
:""	 

AssemblyVersion"" 
("" 
$str"" $
)""$ %
]""% &
[## 
assembly## 	
:##	 

AssemblyFileVersion## 
(## 
$str## (
)##( )
]##) *