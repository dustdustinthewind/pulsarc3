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

	public void SelectFile()
	{
		StartCoroutine(Select(result));
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

	public void NCICCMIOIEA()
	{
		StartCoroutine(EABEPBGOBNE(result));
	}

	public IEnumerator OKLCBLGHKDE(string BNJFKKGOACF)
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

	public void IJPIBDCPFGD()
	{
		StartCoroutine(DOMGEILLMJH(result));
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

	public void JFBMIIDCFLI()
	{
		StartCoroutine(PPFJBPAAEON(result));
	}

	public void PAFNGGDJCEJ()
	{
		StartCoroutine(EKJMJBJGINA(result));
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

	public void BCJODKHKFGM()
	{
		StartCoroutine(IHNBDJMNNCN(result));
	}

	public void DDHCJDDCGJB()
	{
		StartCoroutine(NDHAPEKJGLE(result));
	}

	public void AFFKPKAALCF()
	{
		StartCoroutine(EABEPBGOBNE(result));
	}

	public IEnumerator MFILDNIGKGO(string BNJFKKGOACF)
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

	public void FHKAEOIOMJE()
	{
		StartCoroutine(DOMGEILLMJH(result));
	}

	public IEnumerator EKBFEHNKEDA(string BNJFKKGOACF)
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

	public IEnumerator OGKCIDHCHEC(string BNJFKKGOACF)
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

	public IEnumerator CFCAHPOENHO(string BNJFKKGOACF)
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

	public IEnumerator PINIDCNJMIC(string BNJFKKGOACF)
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

	public void INNAECEKKBH()
	{
		StartCoroutine(IHLPFFEFNDN(result));
	}

	public void OEAFNCEELAD()
	{
		StartCoroutine(PKPOMIAJKKD(result));
	}

	public void KHAECNKOKIB()
	{
		StartCoroutine(MCDNOKAMKDE(result));
	}

	public void AINHODMBCNE()
	{
		StartCoroutine(CFCAHPOENHO(result));
	}

	public void HEMNBIHCDAC()
	{
		StartCoroutine(GNKLLIABLOP(result));
	}

	public void IPLAJIODIKM()
	{
		StartCoroutine(OGKCIDHCHEC(result));
	}

	public IEnumerator OFFOODDOPAG(string BNJFKKGOACF)
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

	public void ALCPMHMCFBG()
	{
		StartCoroutine(PKPOMIAJKKD(result));
	}

	public void FKIAAOEIDKP()
	{
		StartCoroutine(CFCAHPOENHO(result));
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

	public void PELDILPMGIG()
	{
		StartCoroutine(BOBMDOJALEC(result));
	}

	public IEnumerator JLKDLOIBNMF(string BNJFKKGOACF)
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

	public void LPAKMJIHOAL()
	{
		StartCoroutine(PPFJBPAAEON(result));
	}

	public void GBPFEDFFEKG()
	{
		StartCoroutine(JDBGFFFEONP(result));
	}

	public IEnumerator LJNLFIHEEHO(string BNJFKKGOACF)
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

	public void AEEABNAHHKJ()
	{
		StartCoroutine(IHNBDJMNNCN(result));
	}

	public void LFDBEBOPMEG()
	{
		StartCoroutine(CFCAHPOENHO(result));
	}

	public IEnumerator IBGDPKOHMNK(string BNJFKKGOACF)
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

	public void CAFNPKJKNOA()
	{
		StartCoroutine(PINIDCNJMIC(result));
	}

	public IEnumerator IHLPFFEFNDN(string BNJFKKGOACF)
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

	public void KGJDMIMHBNA()
	{
		StartCoroutine(NJHHCCGEACF(result));
	}

	public void IAIAJNEHGPJ()
	{
		StartCoroutine(CNDHFHFNCOM(result));
	}

	public void CMIMCKDJHBH()
	{
		StartCoroutine(FCPPLPPLKIP(result));
	}

	public IEnumerator NCMDHCJOIOG(string BNJFKKGOACF)
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

	public void CDPBFOGJBDH()
	{
		StartCoroutine(JDBGFFFEONP(result));
	}

	public void JMCHDAJGEJD()
	{
		StartCoroutine(PINIDCNJMIC(result));
	}

	public IEnumerator PKPOMIAJKKD(string BNJFKKGOACF)
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

	public void PCNMDIPPKHC()
	{
		StartCoroutine(ADKBOAHDMLK(result));
	}

	public void HAPGGKFMFJK()
	{
		StartCoroutine(IHLPFFEFNDN(result));
	}

	public void AMKPMEBHDDH()
	{
		StartCoroutine(IHNBDJMNNCN(result));
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

	public IEnumerator EKJMJBJGINA(string BNJFKKGOACF)
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

	public IEnumerator OANDHFKAHFM(string BNJFKKGOACF)
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

	public void HICDHIJLFJO()
	{
		StartCoroutine(CFCAHPOENHO(result));
	}

	public IEnumerator MLDHBIKGAOC(string BNJFKKGOACF)
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

	public void FDEIKBEABML()
	{
		StartCoroutine(LJNLFIHEEHO(result));
	}

	public void FFGNKDFJIJI()
	{
		StartCoroutine(EABEPBGOBNE(result));
	}

	public IEnumerator DOMGEILLMJH(string BNJFKKGOACF)
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

	public IEnumerator JDBGFFFEONP(string BNJFKKGOACF)
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

	public IEnumerator AJBDONELEBJ(string BNJFKKGOACF)
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

	public IEnumerator ADKBOAHDMLK(string BNJFKKGOACF)
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

	public void GECLNECMKCP()
	{
		StartCoroutine(MCDNOKAMKDE(result));
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

	public void DJBJOMBHJMO()
	{
		StartCoroutine(PPFJBPAAEON(result));
	}

	public IEnumerator NJHHCCGEACF(string BNJFKKGOACF)
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
		StartCoroutine(OGKCIDHCHEC(result));
	}

	public void DCAMDBFIPLH()
	{
		StartCoroutine(DOMGEILLMJH(result));
	}

	public void DEKFAFLCOIP()
	{
		StartCoroutine(OGKCIDHCHEC(result));
	}

	public IEnumerator CNDHFHFNCOM(string BNJFKKGOACF)
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

	public IEnumerator IHNBDJMNNCN(string BNJFKKGOACF)
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

	public void BGGOGOINEED()
	{
		StartCoroutine(EKBFEHNKEDA(result));
	}

	public void DNHNFGJEINP()
	{
		StartCoroutine(JLKDLOIBNMF(result));
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

	public void FHJPHAHBALC()
	{
		StartCoroutine(GNKLLIABLOP(result));
	}

	public void DOHPDBNDGEK()
	{
		StartCoroutine(FMGHJKGBCPD(result));
	}
}
