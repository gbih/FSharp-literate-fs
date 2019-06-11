rem fsformatting version 3.1.0
rem This is a fork of FSharp.Formatting which parses .fs (not .fsx) files. 
rem Compiled files are targetted to net461 and simply copied over to the applicable project.

@echo off

call rm -fr doc-output && mkdir doc-output
call doc-tools/fsformatting.exe literate --processDirectory --inputDirectory "src" --outputDirectory "doc-output" --templateFile "doc-assets/templates/template.html"  --replacements "page-author" "Your name" "project-name" "Learning F#"
