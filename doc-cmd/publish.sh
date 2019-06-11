# fsformatting version 3.1.0
# This is a fork of FSharp.Formatting which parses .fs (not .fsx) files. 
# Compiled files are targetted to net461 and simply copied over to the applicable project.

rm -fr doc-output && mkdir doc-output
mono doc-tools/fsformatting.exe literate --processDirectory --inputDirectory "src" --outputDirectory "doc-output" --templateFile "doc-assets/templates/template.html"  --replacements "page-author" " Your name" "project-name" "Learning F#"
