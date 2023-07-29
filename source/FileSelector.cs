// FileSelector
using System;
using System.Collections;
using System.IO;
using OxOD;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FileSelector : MonoBehaviour
{
	[Serializable]
	public class StringEvent : UnityEvent<string>
	{
	}

	[Header("OxOD Reference")]
	public FileDialog dialog;

	[Header("File Dialog Options")]
	public FileDialog.FileDialogMode mode;

	public string extensions;

	public int maxSize = -1;

	public bool saveLastPath = true;

	[Header("Events")]
	public UnityEvent OnFileSelected;

	public StringEvent OnFileSelectedString;

	[Header("Internal References")]
	public InputField selectedFile;

	[HideInInspector]
	public string result;

	public void GBCGFMJGEBI()
	{
		StartCoroutine(MINHCHHPLAB(result));
	}

	public IEnumerator LLFLGFKAKBP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator NJPKLKNKAGG(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void KHAECNKOKIB()
	{
		StartCoroutine(MEBEKMMKFOO(result));
	}

	public void AEEABNAHHKJ()
	{
		StartCoroutine(LEPEOHFJJDM(result));
	}

	public void PAFNGGDJCEJ()
	{
		StartCoroutine(PPFJBPAAEON(result));
	}

	public IEnumerator PPFJBPAAEON(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void DNHNFGJEINP()
	{
		StartCoroutine(INDAPPMHOCJ(result));
	}

	public void IAIAJNEHGPJ()
	{
		StartCoroutine(GEJKLOJNDFD(result));
	}

	public void GFFICCJNHMA()
	{
		StartCoroutine(ECCJPEGIBNM(result));
	}

	public void HEMNBIHCDAC()
	{
		StartCoroutine(DGPLLJKGIMP(result));
	}

	public void FKIAAOEIDKP()
	{
		StartCoroutine(MINHCHHPLAB(result));
	}

	public IEnumerator NDHAPEKJGLE(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator ECCJPEGIBNM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void DOHPDBNDGEK()
	{
		StartCoroutine(DGPLLJKGIMP(result));
	}

	public IEnumerator EMKJEINLLJD(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator GEJKLOJNDFD(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void KIPKADHBLLK()
	{
		StartCoroutine(BOBMDOJALEC(result));
	}

	public IEnumerator BOBMDOJALEC(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator JODDNKKOFKL(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator HNJPPHHBPNI(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void HFEAFEANNBA()
	{
		StartCoroutine(HMCBBLKONGK(result));
	}

	public void AFFKPKAALCF()
	{
		StartCoroutine(NCCJLJFFDIN(result));
	}

	public IEnumerator FCPPLPPLKIP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void KEIGJBNBALG()
	{
		StartCoroutine(NCCJLJFFDIN(result));
	}

	public IEnumerator HMCBBLKONGK(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator CINOPGELIBO(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator MINHCHHPLAB(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator LOFELHNPENM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator GNKLLIABLOP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void NCICCMIOIEA()
	{
		StartCoroutine(NJPKLKNKAGG(result));
	}

	public void ADKHCIMAGDM()
	{
		StartCoroutine(JODDNKKOFKL(result));
	}

	public IEnumerator MEBEKMMKFOO(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator NCCJLJFFDIN(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void GINBADBDBHK()
	{
		StartCoroutine(INDAPPMHOCJ(result));
	}

	public void KFCOMPNAOFC()
	{
		StartCoroutine(MEBEKMMKFOO(result));
	}

	public IEnumerator FMGHJKGBCPD(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator INDAPPMHOCJ(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void EBGANBHIODB()
	{
		StartCoroutine(Select(result));
	}

	public void FHNENEALHBB()
	{
		StartCoroutine(HNJPPHHBPNI(result));
	}

	public void FHJPHAHBALC()
	{
		StartCoroutine(MCDNOKAMKDE(result));
	}

	public IEnumerator OFGHPPOPIFA(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void KAFFNJNFAEC()
	{
		StartCoroutine(GNKLLIABLOP(result));
	}

	public IEnumerator HOFNMDNHFPM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator LEPEOHFJJDM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator MCDNOKAMKDE(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public IEnumerator DGPLLJKGIMP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void IPLAJIODIKM()
	{
		StartCoroutine(HMCBBLKONGK(result));
	}

	public void SelectFile()
	{
		StartCoroutine(Select(result));
	}

	public IEnumerator EABEPBGOBNE(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void JKOEJIELDOJ()
	{
		StartCoroutine(HNJPPHHBPNI(result));
	}

	public IEnumerator Select(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (mode == FileDialog.FileDialogMode.Open)
		{
			yield return StartCoroutine(dialog.Open(BNJFKKGOACF, extensions, "OPEN FILE", null, maxSize, saveLastPath));
		}
		else
		{
			yield return StartCoroutine(dialog.Save(BNJFKKGOACF, extensions, "SAVE FILE", null, saveLastPath));
		}
		if (dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + dialog.result);
			result = dialog.result;
			selectedFile.text = new FileInfo(dialog.result).Name;
			OnFileSelected.Invoke();
			OnFileSelectedString.Invoke(dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
	}

	public void CMIMCKDJHBH()
	{
		StartCoroutine(JODDNKKOFKL(result));
	}

	public void CJCIJJOBIIK()
	{
		StartCoroutine(NCCJLJFFDIN(result));
	}
}
