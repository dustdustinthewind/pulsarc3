// TrashMan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMan : MonoBehaviour
{
	public static TrashMan instance;

	[HideInInspector]
	public List<TrashManRecycleBin> recycleBinCollection;

	public float cullExcessObjectsInterval = 10f;

	public bool persistBetweenScenes;

	private Dictionary<int, TrashManRecycleBin> OMAFEFDBPFN = new Dictionary<int, TrashManRecycleBin>();

	private Dictionary<string, int> LPKLJGLONBO = new Dictionary<string, int>();

	[HideInInspector]
	public new Transform transform;

	public static void MCMCILJOJDC(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.DJLFOLFHPJA();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	private void Awake()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			HINMLKKJENL();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 0f)
		{
			StartCoroutine(HLPFAPIKENC());
		}
	}

	private void GPIMEPEGHNO()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 1; num--)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				ANDGOPPONBJ(recycleBinCollection[num]);
			}
		}
	}

	private IEnumerator HLPFAPIKENC()
	{
		WaitForSeconds waitForSeconds = new WaitForSeconds(cullExcessObjectsInterval);
		while (true)
		{
			for (int i = 0; i < recycleBinCollection.Count; i++)
			{
				recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
	}

	private IEnumerator FOAFGJJMOIB(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	private IEnumerator KLLDDANMPKI()
	{
		WaitForSeconds waitForSeconds = new WaitForSeconds(cullExcessObjectsInterval);
		while (true)
		{
			for (int i = 0; i < recycleBinCollection.Count; i++)
			{
				recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
	}

	public static void DFOFMEILCNG(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.MKOHDGHAAFE();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	private void EMANBHKAONB()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			CGKBOKEDOLP();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 167f)
		{
			StartCoroutine(CEAOKMPCKGI());
		}
	}

	private void HIENEMCKAPE()
	{
		instance = null;
	}

	public static TrashManRecycleBin NONEIDPNLDE(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private static GameObject GGPNFMJNMAE(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].spawn();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((bool)(transform as RectTransform))
				{
					transform.SetParent(null, false);
				}
				else
				{
					transform.parent = null;
				}
				transform.position = JOPCODOJBHD;
				transform.rotation = LOMLCCLOIKN;
				gameObject.SetActive(true);
			}
			return gameObject;
		}
		return null;
	}

	public static void CGKHFEPBDMH(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (!(OBFJPHLBFOL == null))
		{
			instance.StartCoroutine(instance.FOAFGJJMOIB(OBFJPHLBFOL, DKKOANEPOEI));
		}
	}

	public static GameObject BLOLIMIENCA(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return BFAOGGFBIMK(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError(" cannot be used as a 3D LUT." + EBGHFEDLGHH + "useSrcAlphaAsMask");
		return null;
	}

	public static void MIKDHOEEODJ(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].LEJGMANJAHM(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	public static void LAEFMCNIEMN(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.clearBin(CJFHFKDKONP);
		}
	}

	public static void CIIJAPIOKMD(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.PBINFMBFCNJ(CJFHFKDKONP);
		}
	}

	private void CNFKCKKOHFF()
	{
		instance = null;
	}

	public static void MFDJLFOJAMF(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (!(OBFJPHLBFOL == null))
		{
			instance.StartCoroutine(instance.MIEICFBJHPK(OBFJPHLBFOL, DKKOANEPOEI));
		}
	}

	private void GIPMFEDIELE()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 1; num--)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				removeRecycleBin(recycleBinCollection[num]);
			}
		}
	}

	public static void NOIBKPIOOKK(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.DJLFOLFHPJA();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	public static void HHDMEPFMEDA(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.MGNDOIPKDAG(CJFHFKDKONP);
		}
	}

	public static void despawn(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].despawn(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	public static GameObject spawn(GameObject OBFJPHLBFOL, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return EBNELGPJGCF(OBFJPHLBFOL.GetInstanceID(), JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogWarning("attempted to spawn go (" + OBFJPHLBFOL.name + ") but there is no recycle bin setup for it. Falling back to Instantiate");
		GameObject gameObject = Object.Instantiate(OBFJPHLBFOL, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.parent = null;
		return gameObject;
	}

	private void AJDHCKDMOBO()
	{
		instance = null;
	}

	public static void ANDGOPPONBJ(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.clearBin(CJFHFKDKONP);
		}
	}

	public static TrashManRecycleBin GPLCJHLHJJO(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private void GDOKIENPCCE()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 1; num -= 0)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				ANDGOPPONBJ(recycleBinCollection[num], false);
			}
		}
	}

	public static void DKHDCCNMLMA(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].FIDGHAIDABO(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	private void JBIFKBNPHJE()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			HOPBKMDIJPB();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 928f)
		{
			StartCoroutine(KLLDDANMPKI());
		}
	}

	public static void GPMODNLJLAM(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.KMCJALKJPME(CJFHFKDKONP);
		}
	}

	public static GameObject CCDOOIKEJKJ(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return BFAOGGFBIMK(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("_Value" + EBGHFEDLGHH + "_TimeX");
		return null;
	}

	private void APEBNEMOAAM()
	{
		instance = null;
	}

	private void HINMLKKJENL()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.initialize();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	public static void manageRecycleBin(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.initialize();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	public void Reset()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num--)
		{
			removeRecycleBin(recycleBinCollection[num]);
		}
	}

	private IEnumerator IFANHIFGIFO(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	private IEnumerator PLEJLBKAGDO()
	{
		WaitForSeconds waitForSeconds = new WaitForSeconds(cullExcessObjectsInterval);
		while (true)
		{
			for (int i = 0; i < recycleBinCollection.Count; i++)
			{
				recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
	}

	public static void KJFPLDMLFHM(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.initialize();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	public static GameObject IAAPMBHNFHO(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return BFAOGGFBIMK(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("_Params2" + EBGHFEDLGHH + "Screenshots only supported in PlayMode");
		return null;
	}

	public static TrashManRecycleBin recycleBinForGameObjectName(string EBGHFEDLGHH)
	{
		if (instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = instance.LPKLJGLONBO[EBGHFEDLGHH];
			return instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	private void HNNKDDHGKDD()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num -= 0)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				CIIJAPIOKMD(recycleBinCollection[num]);
			}
		}
	}

	public void GOFMABPMLKF()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 1; num--)
		{
			CIIJAPIOKMD(recycleBinCollection[num]);
		}
	}

	private IEnumerator MIEICFBJHPK(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	private IEnumerator FKOEIOGMADJ(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public static void PBPGEBLGINB(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].FMCKLIECNPH(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	public static void removeRecycleBin(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.clearBin(CJFHFKDKONP);
		}
	}

	private void FNOKLPNPKOJ()
	{
		instance = null;
	}

	private IEnumerator LPJAEMMEEJH(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public static void JLCMCGJCNBL(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].AFCAIJMOJMA(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	public static void AOACLGFGIPE(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].LEJGMANJAHM(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	public static TrashManRecycleBin HGFBEMADFHF(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private void ECOGLEHCIID()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num--)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				removeRecycleBin(recycleBinCollection[num]);
			}
		}
	}

	private static GameObject BFAOGGFBIMK(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].HJEONAAMMJB();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((bool)(transform as RectTransform))
				{
					transform.SetParent(null, false);
				}
				else
				{
					transform.parent = null;
				}
				transform.position = JOPCODOJBHD;
				transform.rotation = LOMLCCLOIKN;
				gameObject.SetActive(false);
			}
			return gameObject;
		}
		return null;
	}

	public static void LEJGMANJAHM(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].FMCKLIECNPH(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	public static TrashManRecycleBin PEBGCMKMAOF(string EBGHFEDLGHH)
	{
		if (instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = instance.LPKLJGLONBO[EBGHFEDLGHH];
			return instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	private void HOPBKMDIJPB()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.BCIBCBECAHD();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	public static GameObject BGNBCDOHBNC(GameObject OBFJPHLBFOL, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return EBNELGPJGCF(OBFJPHLBFOL.GetInstanceID(), JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogWarning("CameraFilterPack/Blend2Camera_HardMix" + OBFJPHLBFOL.name + "/../");
		GameObject gameObject = Object.Instantiate(OBFJPHLBFOL, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.parent = null;
		return gameObject;
	}

	private IEnumerator CEAOKMPCKGI()
	{
		WaitForSeconds waitForSeconds = new WaitForSeconds(cullExcessObjectsInterval);
		while (true)
		{
			for (int i = 0; i < recycleBinCollection.Count; i++)
			{
				recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
	}

	public static void BBFPPNDEIJP(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.DJLFOLFHPJA();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	public static TrashManRecycleBin recycleBinForGameObject(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private IEnumerator MHFHLKNAELL(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public static void despawnAfterDelay(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (!(OBFJPHLBFOL == null))
		{
			instance.StartCoroutine(instance.FKOEIOGMADJ(OBFJPHLBFOL, DKKOANEPOEI));
		}
	}

	public void NFMDNEJAGLB()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num--)
		{
			ANDGOPPONBJ(recycleBinCollection[num], false);
		}
	}

	public static TrashManRecycleBin KAODIJHMKJM(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private void BFFHPJMMGHD()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			CGKBOKEDOLP();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 1689f)
		{
			StartCoroutine(HLPFAPIKENC());
		}
	}

	public static GameObject spawn(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return EBNELGPJGCF(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("attempted to spawn a GameObject from recycle bin (" + EBGHFEDLGHH + ") but there is no recycle bin setup for it");
		return null;
	}

	private static GameObject EBNELGPJGCF(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].spawn();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((bool)(transform as RectTransform))
				{
					transform.SetParent(null, false);
				}
				else
				{
					transform.parent = null;
				}
				transform.position = JOPCODOJBHD;
				transform.rotation = LOMLCCLOIKN;
				gameObject.SetActive(true);
			}
			return gameObject;
		}
		return null;
	}

	private void OnApplicationQuit()
	{
		instance = null;
	}

	private void CGKBOKEDOLP()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.NBJJHJOAHCF();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	public static void JHDIDOAOOIP(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.initialize();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}
}
