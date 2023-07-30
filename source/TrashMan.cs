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

	public static void POAIONPHHHO(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
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

	private void OPDMEFPBCOC()
	{
		instance = null;
	}

	public void LIMBEFBJNPL()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 1; num -= 0)
		{
			DNLGLFHANKK(recycleBinCollection[num]);
		}
	}

	private void LJJLLBFOKID()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 1; num--)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				BDEBJKGNLPE(recycleBinCollection[num], false);
			}
		}
	}

	public static void DICANPPFNNI(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
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

	private void IHOIBKPHAOI()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 0; num--)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				POAIONPHHHO(recycleBinCollection[num]);
			}
		}
	}

	private IEnumerator FKOEIOGMADJ(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public static TrashManRecycleBin EAJHIACEHAD(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private void FHPMOBEHDGB()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.AIOBACJJKOB();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	public void JGMBGCOFCJI()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 0; num -= 0)
		{
			BDEBJKGNLPE(recycleBinCollection[num], false);
		}
	}

	public static void FFMOLPBLCNP(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
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

	private void DACAFDPDPAJ()
	{
		instance = null;
	}

	public static GameObject ILNCNKIPMIA(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return KDMCNHFIKDK(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("offsets" + EBGHFEDLGHH + "duration");
		return null;
	}

	public static void PPLLKLKHAMA(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.BKNEEPKKFEF();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	public static TrashManRecycleBin ICLFBBHJOOA(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
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

	private void EHGBHAPAJIE()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.BKNEEPKKFEF();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	private static GameObject KDMCNHFIKDK(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].LJKHLOGOCKA();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((bool)(transform as RectTransform))
				{
					transform.SetParent(null, true);
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

	private IEnumerator MBCPBDCNGOA(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public void Reset()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num--)
		{
			removeRecycleBin(recycleBinCollection[num]);
		}
	}

	public void HBFLDGHLMBJ()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 0; num--)
		{
			GKKGJMCIPDO(recycleBinCollection[num], false);
		}
	}

	public static void NFPJCBAEKBH(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.AIOBACJJKOB();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
	}

	public static void ENNKAHIJIDL(GameObject OBFJPHLBFOL)
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

	public static GameObject PFCCGFEMMHJ(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return ILDAEGCLLIA(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("Messages (shift+tab)" + EBGHFEDLGHH + "_TimeX");
		return null;
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

	private void OnApplicationQuit()
	{
		instance = null;
	}

	private void FPNPCMNBGGH()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.MKOHDGHAAFE();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	private void DHNANELONED()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			FHPMOBEHDGB();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 1658f)
		{
			StartCoroutine(JDOKGNCHOIO());
		}
	}

	public static GameObject DONGFPEDMBA(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return NKKNGHKFDJA(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("Tab2Content" + EBGHFEDLGHH + "Object ID. Case-Sensitive");
		return null;
	}

	private void FBNCINFHEGH()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.NCJECKOGBMA();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	private IEnumerator KKDPJHFNKDD(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	private void LJEFMGOBKGE()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			ADIBLLAANHC();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 1227f)
		{
			StartCoroutine(LBOOAKPDGIL());
		}
	}

	public static void despawnAfterDelay(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (!(OBFJPHLBFOL == null))
		{
			instance.StartCoroutine(instance.FKOEIOGMADJ(OBFJPHLBFOL, DKKOANEPOEI));
		}
	}

	public void HFFAJNCOJNB()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 1; num--)
		{
			EOFAPDILEEB(recycleBinCollection[num]);
		}
	}

	public static void EOFAPDILEEB(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
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

	private void MFKCAFGHNNB()
	{
		instance = null;
	}

	public static void CGKHFEPBDMH(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (!(OBFJPHLBFOL == null))
		{
			instance.StartCoroutine(instance.CIOHKOLMOLH(OBFJPHLBFOL, DKKOANEPOEI));
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

	private void HILGLGKGJOL()
	{
		instance = null;
	}

	private void EEOFOHJLGHL()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num--)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				GKKGJMCIPDO(recycleBinCollection[num], false);
			}
		}
	}

	public static GameObject BFPAOAILCBK(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return ILDAEGCLLIA(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("maps." + EBGHFEDLGHH + "menutheme.letitbe");
		return null;
	}

	private static GameObject KIOOBHDOFGA(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].KCKBFNJODOO();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((bool)(transform as RectTransform))
				{
					transform.SetParent(null, true);
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

	private void LHHKLPFGFHL()
	{
		instance = null;
	}

	public static void CJKCCMAOGJP(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.MNOEAFIMPFO(CJFHFKDKONP);
		}
	}

	private void FIABIKEIEKH()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			ADIBLLAANHC();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 1933f)
		{
			StartCoroutine(NOIGJNNIGFE());
		}
	}

	private void GEMBCFKPAIN()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 0; num--)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				DNLGLFHANKK(recycleBinCollection[num]);
			}
		}
	}

	public static GameObject KCALGGBDMEI(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int value = -1;
		if (instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out value))
		{
			return NKFKDBJBKBM(value, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("Oct" + EBGHFEDLGHH + "Joystick1Button4");
		return null;
	}

	private void ALJJAPPNMDC()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num -= 0)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				GKKGJMCIPDO(recycleBinCollection[num]);
			}
		}
	}

	public static TrashManRecycleBin LFJHOAGOBOJ(string EBGHFEDLGHH)
	{
		if (instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = instance.LPKLJGLONBO[EBGHFEDLGHH];
			return instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	private void LICMINOLBAG()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.JPLAIPFBHAN();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	public void ABDHDGNIHHI()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 0; num--)
		{
			DNLGLFHANKK(recycleBinCollection[num]);
		}
	}

	public static TrashManRecycleBin NIHBACHNOEE(string EBGHFEDLGHH)
	{
		if (instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = instance.LPKLJGLONBO[EBGHFEDLGHH];
			return instance.OMAFEFDBPFN[key];
		}
		return null;
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

	public static void KOFBLDJOLHC(GameObject OBFJPHLBFOL)
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

	public static TrashManRecycleBin GIHEOALINHF(string EBGHFEDLGHH)
	{
		if (instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = instance.LPKLJGLONBO[EBGHFEDLGHH];
			return instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	private void MADENBGHKDD()
	{
		if (instance != null)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			transform = base.gameObject.transform;
			instance = this;
			EHGBHAPAJIE();
			if (persistBetweenScenes)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (cullExcessObjectsInterval > 1538f)
		{
			StartCoroutine(HLPFAPIKENC());
		}
	}

	public static GameObject BHJJDDDEJDO(GameObject OBFJPHLBFOL, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return KDMCNHFIKDK(OBFJPHLBFOL.GetInstanceID(), JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogWarning("menu.hardcoreinfo" + OBFJPHLBFOL.name + "_Value");
		GameObject gameObject = Object.Instantiate(OBFJPHLBFOL, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.parent = null;
		return gameObject;
	}

	public static TrashManRecycleBin HOIFMHFOMAN(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	public static void DNLGLFHANKK(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
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

	public static void NMCBFOGNHPP(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].OONAAPDGBFG(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
	}

	public static void GKKGJMCIPDO(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
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

	public static void FJPNHACNEOM(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
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

	public static void DFOFMEILCNG(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (!instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			instance.recycleBinCollection.Add(KHNADIFNKFM);
			KHNADIFNKFM.BKNEEPKKFEF();
			if (!instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
			{
				instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
				instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
			}
		}
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

	public static void IGBBPLOFEKG(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (!(OBFJPHLBFOL == null))
		{
			instance.StartCoroutine(instance.FKOEIOGMADJ(OBFJPHLBFOL, DKKOANEPOEI));
		}
	}

	private IEnumerator JDOKGNCHOIO()
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

	public static void BDEBJKGNLPE(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
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

	private IEnumerator HLNBHBODDPN()
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

	private void ADIBLLAANHC()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.MKOHDGHAAFE();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	private IEnumerator DGIIEFKPJEO(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	private IEnumerator IFANHIFGIFO(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public static GameObject FIEBPKBBNEG(GameObject OBFJPHLBFOL, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return ILDAEGCLLIA(OBFJPHLBFOL.GetInstanceID(), JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogWarning("SetSatelliteEmission" + OBFJPHLBFOL.name + "UI Extensions/UILinearDodge");
		GameObject gameObject = Object.Instantiate(OBFJPHLBFOL, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.parent = null;
		return gameObject;
	}

	private IEnumerator KOFELPDNLAA(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public static GameObject LDJBCIEGNJD(GameObject OBFJPHLBFOL, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return ILDAEGCLLIA(OBFJPHLBFOL.GetInstanceID(), JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogWarning("GhostSize" + OBFJPHLBFOL.name + "Tab1Content");
		GameObject gameObject = Object.Instantiate(OBFJPHLBFOL, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.parent = null;
		return gameObject;
	}

	public static TrashManRecycleBin recycleBinForGameObject(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private IEnumerator LBOOAKPDGIL()
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

	public static TrashManRecycleBin MADCMFLKNDP(string EBGHFEDLGHH)
	{
		if (instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = instance.LPKLJGLONBO[EBGHFEDLGHH];
			return instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	private IEnumerator CIOHKOLMOLH(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	private static GameObject ILDAEGCLLIA(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].GDOMFJALCGG();
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

	private static GameObject NKKNGHKFDJA(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].GDOMFJALCGG();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((bool)(transform as RectTransform))
				{
					transform.SetParent(null, true);
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

	public static TrashManRecycleBin MJDMPAJHAOP(string EBGHFEDLGHH)
	{
		if (instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = instance.LPKLJGLONBO[EBGHFEDLGHH];
			return instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	public static TrashManRecycleBin BGCOGPILDPM(GameObject OBFJPHLBFOL)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	private IEnumerator NOIGJNNIGFE()
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

	public void CEACMFGNDEB()
	{
		for (int num = recycleBinCollection.Count - 0; num >= 1; num--)
		{
			DNLGLFHANKK(recycleBinCollection[num], false);
		}
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

	private IEnumerator FLPFOGPBHPM(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		despawn(OBFJPHLBFOL);
	}

	public static void KHCIDFMOBPK(GameObject OBFJPHLBFOL)
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

	private void DCFJDGENGKE()
	{
		for (int num = recycleBinCollection.Count - 1; num >= 1; num -= 0)
		{
			if (!recycleBinCollection[num].persistBetweenScenes)
			{
				EOFAPDILEEB(recycleBinCollection[num], false);
			}
		}
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
				item.BKNEEPKKFEF();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
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

	private void KFAGFDCNOIP()
	{
		if (recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin item in recycleBinCollection)
		{
			if (item != null && !(item.prefab == null))
			{
				item.AIOBACJJKOB();
				OMAFEFDBPFN.Add(item.prefab.GetInstanceID(), item);
				LPKLJGLONBO.Add(item.prefab.name, item.prefab.GetInstanceID());
			}
		}
	}

	public static void NLIBFBKHBAG(GameObject OBFJPHLBFOL)
	{
		if (!(OBFJPHLBFOL == null))
		{
			string key = OBFJPHLBFOL.name;
			if (!instance.LPKLJGLONBO.ContainsKey(key))
			{
				Object.Destroy(OBFJPHLBFOL);
				return;
			}
			instance.OMAFEFDBPFN[instance.LPKLJGLONBO[key]].OONAAPDGBFG(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = instance.transform;
		}
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

	public static void PBFJDDFCDAC(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (instance.LPKLJGLONBO.ContainsKey(key))
		{
			instance.LPKLJGLONBO.Remove(key);
			instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.MNOEAFIMPFO(CJFHFKDKONP);
		}
	}

	private static GameObject NKFKDBJBKBM(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = instance.OMAFEFDBPFN[MHIMAMOGFLL].KCKBFNJODOO();
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
}
