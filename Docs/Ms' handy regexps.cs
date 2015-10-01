############################
# Michaelis' Regexpy Place #
############################

== One-property actors into one-liners ==

# Find:
Actor ([a-zA-Z0-9_]+)[ \t]*:[ \t]*([a-zA-Z0-9_]+)[ \t]*\r\n[ \t]*\{[ \t]*\r\n[ \t]*([\t a-Z0-9\=\:\,\%\.\(\)\[\]\/\\'"\+\-]+)\r\n[ \t]*\}[ \t]*

# Replace:
Actor $1 : $2 { $3 }



== Remove dead script s799 calls ==

# Find:
//ACS_NamedExecute\("s799",0,[0-9]+,0,0\)

# Replace:
\t



== Add a line after each GOTO not followed by a state label ==

# Find:
\r\n([\t]+)Goto ([a-zA-Z0-9\+"]+)[ \t]*\r\n([\t]+)([a-zA-Z0-9]{4} )

# Replace:
\r\n$1Goto $2\r\n$3\r\n$3$4



== Replace all s851 lines with duration of 1 with A_SetPitch ==

# Find:
1[ \t]*//.+s851",0,([\-0-9]+).+

# Replace:
1 A_SetPitch\($1/16384+pitch\)