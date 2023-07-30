// CameraFilterPack_Blend2Camera_LinearDodge
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/LinearDodge")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_LinearDodge : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearDodge";

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

	private void LONLHFLPEJD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -19);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1416f)
			{
				HBJJOCHGOPH = 114f;
			}
			if (Camera2 != null)
			{
				MMOODGIODPC().SetTexture("0,1,false", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("#{0:X2}{1:X2}{2:X2}", BlendFX);
			OOMFJGPAOKL().SetFloat("Mar", SwitchCameraToCamera2);
			EMDFHOKEGNG().SetVector("D-Pad Right", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1125f, 103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIBGAKMKHJJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1735f)
			{
				HBJJOCHGOPH = 458f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture("_Offsets", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("_Contrast", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(". Client should be in a room. Current connectionStateDetailed: ", BlendFX);
			HCGJCMDJPGD().SetFloat("_LightIntensity", SwitchCameraToCamera2);
			KOHGPKOFEJO().SetVector("UpdateDownloadingProgress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 110f, 675f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -61);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGDPIHMAACO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGJKBDGABKM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -79);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MOMGJJDIFFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void LBIOIEANMGI()
	{
	}

	private void DPFOEBCADNP()
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

	private void EHCGBJDFMHG()
	{
	}

	private void EMAMCDFBGOA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 21);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 595f)
			{
				HBJJOCHGOPH = 790f;
			}
			if (Camera2 != null)
			{
				FLOHGDECHHH().SetTexture("CameraFilterPack_VHS1", JDMCFBKJHDD);
			}
			FLOHGDECHHH().SetFloat(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("Keeping GameObject in the scene: ", BlendFX);
			MICHFGAOPKM().SetFloat("plogs", SwitchCameraToCamera2);
			HNICHJCGJOC().SetVector("CameraFilterPack/TV_PlanetMars", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 362f, 457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1132f)
			{
				HBJJOCHGOPH = 1414f;
			}
			if (Camera2 != null)
			{
				DKNJGHFLAIF().SetTexture("y", JDMCFBKJHDD);
			}
			MMOODGIODPC().SetFloat("_CameraToWorldMatrix", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("_FarCamera", BlendFX);
			HCGJCMDJPGD().SetFloat("SetSunInput", SwitchCameraToCamera2);
			NFKFAAHHLLM().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1515f, 1036f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void OOGIHDLBBLM()
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

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 415f)
			{
				HBJJOCHGOPH = 1647f;
			}
			if (Camera2 != null)
			{
				FLOHGDECHHH().SetTexture(" PhotonNetwork.networkingPeer.AvailableRegions ", JDMCFBKJHDD);
			}
			FOOCJIDNGBB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("Y", BlendFX);
			MMOODGIODPC().SetFloat("a month ago", SwitchCameraToCamera2);
			HCGJCMDJPGD().SetVector("&search=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1129f, 379f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIDOPHINPAL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -25);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 277f)
			{
				HBJJOCHGOPH = 1168f;
			}
			if (Camera2 != null)
			{
				FOOCJIDNGBB().SetTexture(";", JDMCFBKJHDD);
			}
			MMOODGIODPC().SetFloat("Set particles start speed", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Drawing_Curve", BlendFX);
			HCGJCMDJPGD().SetFloat("Failed to Destroy objects of playerId: ", SwitchCameraToCamera2);
			OOMFJGPAOKL().SetVector("Operation failed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 341f, 709f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 88);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MGFFNGEGFDC()
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
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -74);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FELENDJEOGA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -8);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JOLKPPEBILA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -125);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void LMKMEJMGDFO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PNLKFANNOKO()
	{
	}

	private void DGCGGKMNPLD()
	{
	}

	private void PAHNKEGFGHB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 77);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 719f)
			{
				HBJJOCHGOPH = 908f;
			}
			if (Camera2 != null)
			{
				FLOHGDECHHH().SetTexture("DifficultyBG", JDMCFBKJHDD);
			}
			DKNJGHFLAIF().SetFloat("maps.", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("_TimeX", BlendFX);
			EMDFHOKEGNG().SetFloat(" cannot be used as a 3D LUT.", SwitchCameraToCamera2);
			HEHKGPKLAKK().SetVector("CameraFilterPack/Gradients_ElectricGradient", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1944f, 514f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1965f)
			{
				HBJJOCHGOPH = 880f;
			}
			if (Camera2 != null)
			{
				FLOHGDECHHH().SetTexture("[RanksSystem] Map hash: ", JDMCFBKJHDD);
			}
			HNICHJCGJOC().SetFloat("\n\n• ", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("float,2", BlendFX);
			FLOHGDECHHH().SetFloat("StartButton", SwitchCameraToCamera2);
			OOMFJGPAOKL().SetVector("FileMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1805f, 644f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1763f)
			{
				HBJJOCHGOPH = 816f;
			}
			if (Camera2 != null)
			{
				OOMFJGPAOKL().SetTexture("Joystick1Button9", JDMCFBKJHDD);
			}
			FOOCJIDNGBB().SetFloat("#pleasewait", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("keep aspect ratio", BlendFX);
			OIIDAKBILMI().SetFloat("th", SwitchCameraToCamera2);
			JIBOKBCPDLC().SetVector("#challengecomplete", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 230f, 1355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDKHBGDEONK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 63);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 68);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDNONDCGGCG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 6);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1816f)
			{
				HBJJOCHGOPH = 1767f;
			}
			if (Camera2 != null)
			{
				FOOCJIDNGBB().SetTexture("Set satellite beat detection sensitivity", JDMCFBKJHDD);
			}
			HNICHJCGJOC().SetFloat("_Value", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("y", BlendFX);
			NBPKMLMCHFN.SetFloat("_SphereSize", SwitchCameraToCamera2);
			EMDFHOKEGNG().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 509f, 490f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMANOEMOCA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFFKKLAPHCC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -31);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 565f)
			{
				HBJJOCHGOPH = 428f;
			}
			if (Camera2 != null)
			{
				HNICHJCGJOC().SetTexture("Cancel", JDMCFBKJHDD);
			}
			FLOHGDECHHH().SetFloat("CameraFilterPack_OldFilm1", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value5", BlendFX);
			KOHGPKOFEJO().SetFloat("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", SwitchCameraToCamera2);
			HEHKGPKLAKK().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 912f, 827f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBAPHFIBANG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -42);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void LDDKCCMHMIC()
	{
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1366f)
			{
				HBJJOCHGOPH = 269f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("Joystick1Button4", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/AAA_WaterDropPro", BlendFX);
			HEHKGPKLAKK().SetFloat("#{0:X2}{1:X2}{2:X2}", SwitchCameraToCamera2);
			OIIDAKBILMI().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 515f, 1868f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void EONOOEJDNEF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MGMLGCNLMKN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 124);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1785f)
			{
				HBJJOCHGOPH = 7f;
			}
			if (Camera2 != null)
			{
				FOOCJIDNGBB().SetTexture("CameraFilterPack/3D_Shield", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("[LevelEditorScene] Error: Timeout :S", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Colored", BlendFX);
			JIBOKBCPDLC().SetFloat("Received OnSerialization for view ID ", SwitchCameraToCamera2);
			FOOCJIDNGBB().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 611f, 379f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IENKPJEBMFM()
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

	private void AJBHOEBKGDO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1659f)
			{
				HBJJOCHGOPH = 1409f;
			}
			if (Camera2 != null)
			{
				FLOHGDECHHH().SetTexture("_ArScale", JDMCFBKJHDD);
			}
			OIIDAKBILMI().SetFloat("?", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("SetSpeed", BlendFX);
			NBPKMLMCHFN.SetFloat("Joystick1Button4", SwitchCameraToCamera2);
			HNICHJCGJOC().SetVector("stretchWidth", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1288f, 484f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void JNACKHNNEPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -91);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 581f)
			{
				HBJJOCHGOPH = 177f;
			}
			if (Camera2 != null)
			{
				MMOODGIODPC().SetTexture("GlassesColor2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_SphereSize", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat(" from: ", BlendFX);
			MICHFGAOPKM().SetFloat(".jpg", SwitchCameraToCamera2);
			FLOHGDECHHH().SetVector("ns", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 56f, 260f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AAPKKMKDOFO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 102);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NAALCEPIHCH()
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
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1118f)
			{
				HBJJOCHGOPH = 1164f;
			}
			if (Camera2 != null)
			{
				HNICHJCGJOC().SetTexture("<b>#", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_Value", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("ViewMenu", BlendFX);
			EMDFHOKEGNG().SetFloat("Overlay", SwitchCameraToCamera2);
			HCGJCMDJPGD().SetVector("achievements.21.progress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 378f, 1495f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void IDJKNBDKHBD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 20);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DIPDEHOOBPG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -70);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1505f)
			{
				HBJJOCHGOPH = 75f;
			}
			if (Camera2 != null)
			{
				OOMFJGPAOKL().SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			MMOODGIODPC().SetFloat(".lastCheckpoint.checkpointsUsed", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("_HSV", BlendFX);
			NBPKMLMCHFN.SetFloat("Drop_Near", SwitchCameraToCamera2);
			JIBOKBCPDLC().SetVector("open", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 876f, 492f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -88);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ANKALNDLHEL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -40);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NEGKFLLFLOK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DNNFHBOOPIN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1683f)
			{
				HBJJOCHGOPH = 1517f;
			}
			if (Camera2 != null)
			{
				HEHKGPKLAKK().SetTexture("MenuScene", JDMCFBKJHDD);
			}
			HEHKGPKLAKK().SetFloat("Operation ", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("ItemsCountText", BlendFX);
			OIIDAKBILMI().SetFloat("x", SwitchCameraToCamera2);
			KOHGPKOFEJO().SetVector("mapselector.filter.rateduponly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 475f, 1616f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void HIFLPHLGLFG()
	{
	}

	private void BMOFEBKGLFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 94);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMKDEKCELE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1459f)
			{
				HBJJOCHGOPH = 1922f;
			}
			if (Camera2 != null)
			{
				OOMFJGPAOKL().SetTexture("inventory.selected.", JDMCFBKJHDD);
			}
			NFKFAAHHLLM().SetFloat("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("Set crosshair emission (glow)", BlendFX);
			DKNJGHFLAIF().SetFloat("#md5submitionfailed: ", SwitchCameraToCamera2);
			MMOODGIODPC().SetVector("Using constructor for new PingNativeStatic()", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1945f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -7);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MLEAHDDGEMJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PKLOBJHKFEO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -89);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 28f)
			{
				HBJJOCHGOPH = 1392f;
			}
			if (Camera2 != null)
			{
				HCGJCMDJPGD().SetTexture("_Visualize", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("Operation failed: ", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("...", BlendFX);
			HEHKGPKLAKK().SetFloat("#close", SwitchCameraToCamera2);
			NFKFAAHHLLM().SetVector("Yes", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1045f, 1501f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLIKADJCEPO()
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

	private void KDJEJBBDILE()
	{
	}

	private void LKPBGHGCPKL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -25);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 183f)
			{
				HBJJOCHGOPH = 1450f;
			}
			if (Camera2 != null)
			{
				FOOCJIDNGBB().SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			OIIDAKBILMI().SetFloat("Vertical", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", BlendFX);
			HEHKGPKLAKK().SetFloat("Spawn ark to be pressed at this time", SwitchCameraToCamera2);
			OOMFJGPAOKL().SetVector("UNDISTORT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1328f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MFLBEJHMEMO()
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

	private void GNMGIHFKJIJ()
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

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1059f)
			{
				HBJJOCHGOPH = 600f;
			}
			if (Camera2 != null)
			{
				MICHFGAOPKM().SetTexture("shader.sunny", JDMCFBKJHDD);
			}
			FOOCJIDNGBB().SetFloat("GameScene", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("map.data", BlendFX);
			NFKFAAHHLLM().SetFloat("player.gamecompleted", SwitchCameraToCamera2);
			DKNJGHFLAIF().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 423f, 1769f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
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

	private void INGOODALACO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -108);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EKCKJLFFAID()
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

	private void GCHBGCGBMCK()
	{
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
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

	private void NCNPAKFAFOE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 108);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IMCKJCHKMKB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 100);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BHBCNNIJECK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 17);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NKFDNIAKGEO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -14);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KHDANGFKIGL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -42);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}
}
