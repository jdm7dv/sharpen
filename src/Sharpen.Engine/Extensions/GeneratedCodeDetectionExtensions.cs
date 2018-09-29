﻿using System;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Sharpen.Engine.Extensions
{
    // TODO-SETTINGS: In the future we will have this in Sharpen Settings, similar to the equivalent ReSharper settings.

    /// <summary>
    /// Contains extension methods related to the detection
    /// of generate code.
    /// </summary>
    internal static class GeneratedCodeDetectionExtensions
    {
        private static readonly char[] Separators =
        {
            Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar, Path.VolumeSeparatorChar
        };

        public const string AutoGeneratedTag = "<auto-generated>";
        private static readonly int AutoGeneratedCommentMinLength = AutoGeneratedTag.Length + 2;

        public static bool IsGenerated(this Document document)
        {
            return IsGeneratedFile(document.FilePath);
        }

        // The implementation has been taken from Josef Pihrt's Roslynator:
        // https://github.com/JosefPihrt/Roslynator/blob/a6ed824a390831fa67e0dbb3710418239654a88e/src/CSharp/GeneratedCodeUtility.cs#L1
        private static bool IsGeneratedFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath)) return false;

            int directorySeparatorIndex = filePath.LastIndexOfAny(Separators);

            if (string.Compare("TemporaryGeneratedFile_", 0, filePath, directorySeparatorIndex + 1, "TemporaryGeneratedFile_".Length, StringComparison.OrdinalIgnoreCase) == 0)
                return true;

            int dotIndex = filePath.LastIndexOf(".", filePath.Length - 1, filePath.Length - directorySeparatorIndex - 1, StringComparison.Ordinal);

            if (dotIndex == -1)
                return false;

            return IsMatch(".Designer")
                   || IsMatch(".Generated")
                   || IsMatch(".g")
                   || IsMatch(".g.i")
                   || IsMatch(".AssemblyAttributes");

            bool IsMatch(string value)
            {
                int length = value.Length;

                int index = dotIndex - length;

                return index >= 0
                       && string.Compare(value, 0, filePath, index, length, StringComparison.OrdinalIgnoreCase) == 0;
            }
        }

        // The implementation has been taken from Josef Pihrt's Roslynator:
        // https://github.com/JosefPihrt/Roslynator/blob/b2c2493c880ccd06215a11fa7b42b64a1fea0470/src/CSharp/CSharp/CSharpGeneratedCodeAnalyzer.cs#L21
        public static bool BeginsWithAutoGeneratedComment(this SyntaxTree tree)
        {
            if (!tree.TryGetRoot(out SyntaxNode root)) return false;

            if (root?.Kind() != SyntaxKind.CompilationUnit) return false;

            SyntaxTriviaList leadingTrivia = root.GetLeadingTrivia();

            if (!leadingTrivia.Any()) return false;

            foreach (SyntaxTrivia trivia in leadingTrivia)
            {
                if (trivia.Kind() != SyntaxKind.SingleLineCommentTrivia) continue;

                string text = trivia.ToString();

                if (text.Length >= AutoGeneratedCommentMinLength
                    && text[0] == '/'
                    && text[1] == '/')
                {
                    int index = 2;

                    while (index < text.Length
                           && char.IsWhiteSpace(text[index]))
                    {
                        index++;
                    }

                    if (string.Compare(text, index, AutoGeneratedTag, 0, AutoGeneratedTag.Length, StringComparison.OrdinalIgnoreCase) == 0)
                        return true;
                }
            }

            return false;
        }
    }
}
