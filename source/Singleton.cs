// Singleton<T>
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	public bool dontDestroyOnLoad = true;

	private static T BFKGHEBNCKL;

	public static T Instance
	{
		get
		{
			if ((Object)BFKGHEBNCKL == (Object)null)
			{
				BFKGHEBNCKL = (T)Object.FindObjectOfType(typeof(T));
				if (Object.FindObjectsOfType(typeof(T)).Length > 1)
				{
					Debug.LogError(string.Concat("[Singleton] multiple instances of '", typeof(T), "' found!"));
				}
				if ((Object)BFKGHEBNCKL == (Object)null)
				{
					GameObject gameObject = new GameObject();
					BFKGHEBNCKL = gameObject.AddComponent<T>();
					gameObject.name = "(singleton) " + typeof(T).ToString();
					Object.DontDestroyOnLoad(gameObject);
					Debug.Log(string.Concat("[Singleton] An instance of '", typeof(T), "' was created: ", gameObject));
				}
				else
				{
					Debug.Log(string.Concat("[Singleton] Using instance of '", typeof(T), "': ", BFKGHEBNCKL.gameObject.name));
				}
			}
			return BFKGHEBNCKL;
		}
	}

	public void IICACFLHBCP()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void EPCGHAAONLN()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void JIJPHEDDIHC()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void DHNANELONED()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void LBOBAIGNOML()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void GEGFJJBCHPE()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void MADENBGHKDD()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void POHMFMNEPKK()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void JBIFKBNPHJE()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void HHJBBHEBJCJ()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void CCDNJPNLGBN()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void IIPMEPPIFCK()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void LOMHIIKFFEP()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void PEMPABLNJHL()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void AJIKPEIGACI()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void CJHMHIMKILB()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void BMAGFLLGDPJ()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void JPJNECPABBG()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void PPCGJBIIFAO()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void OPFDGBDADMA()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void MMPOJCFOGJJ()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void NLNAJMCBNDC()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void Awake()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void JEEINPBLBDI()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void BFFHPJMMGHD()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void BFIOIDMHPPL()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void BODPLDJLFCF()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void PIIMBOLGHOE()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void KGMCGGIEPDE()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void EPCAPPLPFED()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void GOBHPAJFFDB()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void BHCCNFJKGPD()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void DMIKIDGJEFC()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void FMAFBLKAJDF()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void FNMPIAMIKCP()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void OKADMJFLMGP()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void CIAHIJIOFIE()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void CEKLAECJCKG()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void HCNECNPPEKA()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void EIFCCFBJKOO()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void JHPKLGGMCBL()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 1)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}

	public void FAAJAMIGJNK()
	{
		if (dontDestroyOnLoad)
		{
			Object.DontDestroyOnLoad(base.transform.gameObject);
			if (Object.FindObjectsOfType(GetType()).Length > 0)
			{
				Object.Destroy(base.gameObject);
			}
		}
		if (!(Object)BFKGHEBNCKL)
		{
			BFKGHEBNCKL = base.gameObject.GetComponent<T>();
		}
	}
}
