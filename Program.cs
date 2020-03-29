﻿using System;
using System.Text;
using System.Drawing.Text;
using System.IO;

namespace irl_fontbook
{
    class Program
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"
			<html>
			<head>
			<style>
			table {
			border-collapse: collapse;
			width: 100%;
			}
			
			th, td {
			text-align: left;
			padding: 8px;
			}
			
			tr:nth-child(even) {background-color: #f2f2f2;}
			</style>
			</head>
			<table>
			");
            var installedFonts = new InstalledFontCollection();

            int count = 1;
            foreach (var fontFamily in installedFonts.Families)
            {
                sb.AppendLine($@"<tr><td>{count++}</td>
									<td>{fontFamily.Name}</td>
									<td><span style=""font-size: 24px; font-family: {fontFamily.Name};"">
										THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
										<br />
										The quick brown fox jumps over the lazy dog
										<br />
										0 1 2 3 4 5 6 7 8 9 , . ? ! @ # $ % ^ & * ( ) [] ; ' : ""
									</span></td></tr>");
            }

            sb.AppendLine(@"
			</table>
			</html>
			");

            var htmlFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"irl_fontbook_{DateTime.Now.Ticks}.html"));
            File.WriteAllText(htmlFile.FullName, sb.ToString());
            Console.WriteLine(htmlFile.FullName);
        }
    }
}
