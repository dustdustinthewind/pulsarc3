// CameraFilterPack_Blend2Camera_Hue
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Hue")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Hue : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Hue";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

	private Material NBPKMLMCHFN
	{
		get
		{
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return BJFKDHHMLJH;
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFBCLNAHEFO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MPENCEIGLEH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LHGFCBDACBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1297f)
			{
				HBJJOCHGOPH = 710f;
			}
			if (Camera2 != null)
			{
				ACHNOHCLGOO().SetTexture("win", JDMCFBKJHDD);
			}
			ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Myst", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_Parameter", BlendFX);
			ACHNOHCLGOO().SetFloat("Joystick1Button4", SwitchCameraToCamera2);
			MICHFGAOPKM().SetVector("No connection to item server!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1498f, 620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BBKMHAFFIMD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KDMANOEMOCA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void KCDAFGECAIH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -67);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JNACKHNNEPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -107);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KFEKCJDEECK()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void ACBAHLCGNDD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -102);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FEHCNJLLJMP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -60);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OAKONCDEPPI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -10);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BMOFEBKGLFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 63);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 75);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 804f)
			{
				HBJJOCHGOPH = 298f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture("_DotSize", JDMCFBKJHDD);
			}
			MICHFGAOPKM().SetFloat("LevelNameInputField", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("x", BlendFX);
			ELBMIEOIABA().SetFloat(" ", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 789f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KMOCDAOKGLI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void BLDMINMDHPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DLMPALHKMON()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MEJPBKFMAIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void JCDPMLPNOOC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EBBMDDEFNKL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -17);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IHPLMLBJELK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1475f)
			{
				HBJJOCHGOPH = 831f;
			}
			if (Camera2 != null)
			{
				NFMGLIKNOOC().SetTexture("_Green_C", JDMCFBKJHDD);
			}
			KHCLIAMBBNC().SetFloat("inventory.selected.", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("[Down-Left]", BlendFX);
			KHCLIAMBBNC().SetFloat("Hex value #RRGGBB", SwitchCameraToCamera2);
			DKNJGHFLAIF().SetVector("caret", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1530f, 1959f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1856f)
			{
				HBJJOCHGOPH = 24f;
			}
			if (Camera2 != null)
			{
				KHCLIAMBBNC().SetTexture("_Value", JDMCFBKJHDD);
			}
			MICHFGAOPKM().SetFloat("_FgOverlap", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("settings.enableranking", BlendFX);
			PLBEJJIHFPB().SetFloat("_CenterX", SwitchCameraToCamera2);
			GCDFNHMJMIP().SetVector("ChangeSelectedLevel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1626f, 1514f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MIAMLFNACAI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LKPBGHGCPKL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OEIBFOHPOPD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 825f)
			{
				HBJJOCHGOPH = 14f;
			}
			if (Camera2 != null)
			{
				GJHPODJOBHL().SetTexture("CameraFilterPack/Light_Water2", JDMCFBKJHDD);
			}
			KHCLIAMBBNC().SetFloat("#FFDA44CC", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("red", BlendFX);
			KHCLIAMBBNC().SetFloat("SetParticlesCountPerBeat", SwitchCameraToCamera2);
			KHCLIAMBBNC().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1036f, 51f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FODKODGPPDA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void KDMKDEKCELE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EAOKCECGKAK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HLIAEEMGBHN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 61);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PKNJBBDKJFK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FOAGAKFBIGD()
	{
	}

	private void NNPBKKBFDHH()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNLPEJJPEGA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 64);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PMPKMGKAAJH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -33);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1416f)
			{
				HBJJOCHGOPH = 1763f;
			}
			if (Camera2 != null)
			{
				CFEDGDGBCHE().SetTexture("_Value2", JDMCFBKJHDD);
			}
			OIBHFCLJKDB().SetFloat("_TimeX", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat(".", BlendFX);
			BAGICADFBAB().SetFloat("Added event", SwitchCameraToCamera2);
			DKNJGHFLAIF().SetVector("checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 446f, 1140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void FCGHOKACFHL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KKGMKGHFELO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MKIMDFLBFOM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ICILLMAKLMI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 115);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1862f)
			{
				HBJJOCHGOPH = 173f;
			}
			if (Camera2 != null)
			{
				ELBMIEOIABA().SetTexture("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", JDMCFBKJHDD);
			}
			OCMBHMLNCEK().SetFloat("_Value4", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("shaders", BlendFX);
			KHCLIAMBBNC().SetFloat("Joystick1Button4", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetVector("getbool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 805f, 1809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void ANKALNDLHEL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -30);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void FINDGJLEHOL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 120);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 56f)
			{
				HBJJOCHGOPH = 1989f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("Source Object: ", JDMCFBKJHDD);
			}
			KOHGPKOFEJO().SetFloat("|", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_Value8", BlendFX);
			ACHNOHCLGOO().SetFloat("SupportLogger OnConnectedToPhoton().", SwitchCameraToCamera2);
			PLBEJJIHFPB().SetVector("CameraFilterPack/FX_Ascii", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 102f, 973f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 358f)
			{
				HBJJOCHGOPH = 1342f;
			}
			if (Camera2 != null)
			{
				BAGICADFBAB().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", JDMCFBKJHDD);
			}
			MICHFGAOPKM().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat(") but there is no recycle bin setup for it", BlendFX);
			DBOLLHHMKKN().SetFloat("_TimeX", SwitchCameraToCamera2);
			OIBHFCLJKDB().SetVector("mapid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1844f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJFBCFBKLD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void DBIBFOINCKM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HMKJFPBFOFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JLNNHKPHMAB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 426f)
			{
				HBJJOCHGOPH = 459f;
			}
			if (Camera2 != null)
			{
				HNFFHCLNBDN().SetTexture("ScoreText", JDMCFBKJHDD);
			}
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Colors_HUE_Rotate", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("1234332714", BlendFX);
			NFMGLIKNOOC().SetFloat("_Intensity", SwitchCameraToCamera2);
			HNFFHCLNBDN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1178f, 313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 849f)
			{
				HBJJOCHGOPH = 269f;
			}
			if (Camera2 != null)
			{
				ELBMIEOIABA().SetTexture("maps.", JDMCFBKJHDD);
			}
			GCDFNHMJMIP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", BlendFX);
			CFEDGDGBCHE().SetFloat("rd", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetVector("true", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1086f, 751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LINKAMEPKGM()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HPFIHLMKIPF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 66f)
			{
				HBJJOCHGOPH = 116f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture("Bad parameters for setbool! Use <key> <value>", JDMCFBKJHDD);
			}
			ACHNOHCLGOO().SetFloat("_Value4", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_Visualize", BlendFX);
			GCDFNHMJMIP().SetFloat("_Value6", SwitchCameraToCamera2);
			DBOLLHHMKKN().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 420f, 253f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JIPEMDLKAGO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1830f)
			{
				HBJJOCHGOPH = 1696f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture(" ", JDMCFBKJHDD);
			}
			HILDKDFEBPF().SetFloat("_TimeX", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("mapselector.filter.rateduponly", BlendFX);
			NBPKMLMCHFN.SetFloat("ScreenResolutionPanel", SwitchCameraToCamera2);
			HNFFHCLNBDN().SetVector("action", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 539f, 1014f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void EDCMIPNCPLB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ELBMIEOIABA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void FDMAEPOHDMK()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LOLHKNKBNPF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 517f)
			{
				HBJJOCHGOPH = 1983f;
			}
			if (Camera2 != null)
			{
				PLBEJJIHFPB().SetTexture("_SecondTex", JDMCFBKJHDD);
			}
			OCMBHMLNCEK().SetFloat("YES", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_Green_B", BlendFX);
			MICHFGAOPKM().SetFloat("_Intensity", SwitchCameraToCamera2);
			MICHFGAOPKM().SetVector("[CraftingPanel] Init", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1436f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFIHBNJKEKD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void ODGMCJILIHF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MHHMIFHKEDH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 10);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void COCBPFHHLGI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -36);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JKFDDNMPOJH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -18);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1825f)
			{
				HBJJOCHGOPH = 1128f;
			}
			if (Camera2 != null)
			{
				KHCLIAMBBNC().SetTexture("Soundtrack", JDMCFBKJHDD);
			}
			ELBMIEOIABA().SetFloat("#getrewardfailed: ", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("offsets", BlendFX);
			NBPKMLMCHFN.SetFloat("player.xp", SwitchCameraToCamera2);
			KHCLIAMBBNC().SetVector("#91CCFF", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 607f, 1796f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BHBCNNIJECK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -7);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KMCPMOGKDEH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 34);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 424f)
			{
				HBJJOCHGOPH = 65f;
			}
			if (Camera2 != null)
			{
				ACHNOHCLGOO().SetTexture("_DotSize", JDMCFBKJHDD);
			}
			CFEDGDGBCHE().SetFloat("health", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_Distortion", BlendFX);
			ACHNOHCLGOO().SetFloat("_Value", SwitchCameraToCamera2);
			BAGICADFBAB().SetVector("Back", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 409f, 1582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FPBIGAKLKIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -16);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AOKOLPEGHDD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OOHJBHLKGDJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -83);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LMKMEJMGDFO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ALNNIDLFILB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HHODKHPIBLG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EAFFHHCMLCG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void NEGKFLLFLOK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 72);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GNPDGBNDCPL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1314f)
			{
				HBJJOCHGOPH = 1930f;
			}
			if (Camera2 != null)
			{
				KHCLIAMBBNC().SetTexture("PLAY [SPACE]", JDMCFBKJHDD);
			}
			ELBMIEOIABA().SetFloat("settings.fps", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("OpSetPropertiesOfActor()", BlendFX);
			PLBEJJIHFPB().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", SwitchCameraToCamera2);
			MPENCEIGLEH().SetVector("CameraFilterPack/Blur_Blurry", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1842f, 738f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 999f)
			{
				HBJJOCHGOPH = 1616f;
			}
			if (Camera2 != null)
			{
				KBOPGONOCNP().SetTexture("{0:0.0} ms ({1:0.} fps)", JDMCFBKJHDD);
			}
			KBOPGONOCNP().SetFloat("Joystick1Button8", HBJJOCHGOPH);
			MPENCEIGLEH().SetFloat("HPText", BlendFX);
			MICHFGAOPKM().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			GJHPODJOBHL().SetVector(".workshop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 744f, 1369f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1509f)
			{
				HBJJOCHGOPH = 1583f;
			}
			if (Camera2 != null)
			{
				ACHNOHCLGOO().SetTexture("recipes", JDMCFBKJHDD);
			}
			ELBMIEOIABA().SetFloat("CameraFilterPack/Glow_Glow", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_ChangeRed", BlendFX);
			NFMGLIKNOOC().SetFloat("#", SwitchCameraToCamera2);
			KOHGPKOFEJO().SetVector("InfoButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1265f, 594f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEAGPJBGBMH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LOMDIOLNFHI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FKEJGBFDCAH()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AJENCHHLHKF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 98);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HOPAMNJIBHA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -92);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AMHEJBMLFNM()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1013f)
			{
				HBJJOCHGOPH = 1525f;
			}
			if (Camera2 != null)
			{
				NFMGLIKNOOC().SetTexture("workshop.txt", JDMCFBKJHDD);
			}
			DBOLLHHMKKN().SetFloat("Status: ", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("ResetButton", BlendFX);
			HNFFHCLNBDN().SetFloat("Creating new item...", SwitchCameraToCamera2);
			HNFFHCLNBDN().SetVector("_Val3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1460f, 542f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIAICHPPGBP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void LJEDJDGPGFG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material HILDKDFEBPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 523f)
			{
				HBJJOCHGOPH = 1282f;
			}
			if (Camera2 != null)
			{
				KOHGPKOFEJO().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			HNFFHCLNBDN().SetFloat("mapselector.filter.favoriteonly", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("{0}_{1}", BlendFX);
			DKNJGHFLAIF().SetFloat("Set the end of the map. Use this if you want to cut the long music.", SwitchCameraToCamera2);
			HILDKDFEBPF().SetVector("SendVacantViewIds()", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1594f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFELOCODMPJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EKPLGFAEOBE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 114f)
			{
				HBJJOCHGOPH = 863f;
			}
			if (Camera2 != null)
			{
				ACHNOHCLGOO().SetTexture("CameraFilterPack/3D_Binary", JDMCFBKJHDD);
			}
			HNFFHCLNBDN().SetFloat("Keypad ", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("yyyy-MM-dd HH:mm:ss", BlendFX);
			ACHNOHCLGOO().SetFloat("^", SwitchCameraToCamera2);
			DKNJGHFLAIF().SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1125f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 790f)
			{
				HBJJOCHGOPH = 613f;
			}
			if (Camera2 != null)
			{
				GJHPODJOBHL().SetTexture("speed", JDMCFBKJHDD);
			}
			KOHGPKOFEJO().SetFloat("_CurveParams", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("CameraFilterPack_TV_Arcade1", BlendFX);
			DBOLLHHMKKN().SetFloat("player.rgb", SwitchCameraToCamera2);
			GCDFNHMJMIP().SetVector("ShadersToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1929f, 1957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void DAHFFNNIGML()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -53);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GBGAMCPNBCC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
