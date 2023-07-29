// ClipboardExtension
using UnityEngine;

public static class ClipboardExtension
{
	public static void CopyToClipboard(this string LEFMNANHGDA)
	{
		TextEditor textEditor = new TextEditor();
		textEditor.text = LEFMNANHGDA;
		textEditor.SelectAll();
		textEditor.Copy();
	}
}
