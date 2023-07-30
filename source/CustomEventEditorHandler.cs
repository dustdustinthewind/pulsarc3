// CustomEventEditorHandler
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomEventEditorHandler : MonoBehaviour
{
	public EditorEventFunctionInfo.EditorEventParametr currentParametr;

	public string data = string.Empty;

	public List<string> advParametrs;

	public virtual void BGFJOEPFOPM()
	{
	}

	public virtual void LKEPIEEIMAE(string NOJGGCLPPAM, string BNPGLCAHPDL = null)
	{
		data = NOJGGCLPPAM;
		if (!string.IsNullOrEmpty(BNPGLCAHPDL))
		{
			char[] array = new char[0];
			array[0] = 'ﾱ';
			advParametrs = BNPGLCAHPDL.Split(array).OfType<string>().ToList();
		}
	}

	public virtual string NCKBLEFJJGL()
	{
		return data;
	}

	public virtual void JAAJECBCCFM()
	{
	}

	public virtual string GetEditedData()
	{
		return data;
	}

	public virtual string OLDDPMNNCLG()
	{
		return data;
	}

	public virtual void HBKEHHCMMBN(string NOJGGCLPPAM, string BNPGLCAHPDL = null)
	{
		data = NOJGGCLPPAM;
		if (!string.IsNullOrEmpty(BNPGLCAHPDL))
		{
			advParametrs = BNPGLCAHPDL.Split('\\').OfType<string>().ToList();
		}
	}

	public virtual void Update()
	{
	}

	public virtual string NCOPOFANBEG()
	{
		return data;
	}

	public virtual void Init(string NOJGGCLPPAM, string BNPGLCAHPDL = null)
	{
		data = NOJGGCLPPAM;
		if (!string.IsNullOrEmpty(BNPGLCAHPDL))
		{
			advParametrs = BNPGLCAHPDL.Split(',').OfType<string>().ToList();
		}
	}

	public virtual void NFKDBPGHHIJ(string NOJGGCLPPAM, string BNPGLCAHPDL = null)
	{
		data = NOJGGCLPPAM;
		if (!string.IsNullOrEmpty(BNPGLCAHPDL))
		{
			advParametrs = BNPGLCAHPDL.Split('\ufff4').OfType<string>().ToList();
		}
	}

	public virtual void EPDCHKECMBL(string NOJGGCLPPAM, string BNPGLCAHPDL = null)
	{
		data = NOJGGCLPPAM;
		if (!string.IsNullOrEmpty(BNPGLCAHPDL))
		{
			advParametrs = BNPGLCAHPDL.Split('￮').OfType<string>().ToList();
		}
	}

	public virtual void FIMJABKECNG(string NOJGGCLPPAM, string BNPGLCAHPDL = null)
	{
		data = NOJGGCLPPAM;
		if (!string.IsNullOrEmpty(BNPGLCAHPDL))
		{
			advParametrs = BNPGLCAHPDL.Split('ﾨ').OfType<string>().ToList();
		}
	}
}
