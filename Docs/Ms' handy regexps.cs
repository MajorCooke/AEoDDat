############################
# Michaelis' Regexpy Place #
############################

== One-property actors into one-liners ==

# Find:
Actor ([a-zA-Z0-9_]+)[ \t]*:[ \t]*([a-zA-Z0-9_]+)[ \t]*\r\n[ \t]*\{[ \t]*\r\n[ \t]*([\t a-Z0-9\.\(\)\[\]\/\\'"]+)\r\n[ \t]*\}[ \t]*

# Replace:
Actor $1 : $2 { $3 }



== Remove dead script s799 calls ==

# Find:
//ACS_NamedExecute\("s799",0,[0-9]+,0,0\)

# Replace:
\t