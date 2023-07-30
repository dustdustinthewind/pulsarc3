// CameraFilterPack_Distortion_Flush
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Flush")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Flush : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-10f, 50f)]
	public float Value = 5f;

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

	private void CGBHOELMAOC()
	{
	}

	private void EKPLGFAEOBE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCGMGLMADEN()
	{
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 189f)
			{
				HBJJOCHGOPH = 633f;
			}
			LPDOGGFOBDH().SetFloat("float,1", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("SlidingArea", Value);
			DKNJGHFLAIF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 208f, 605f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1335f)
			{
				HBJJOCHGOPH = 246f;
			}
			DKNJGHFLAIF().SetFloat("Destroying GO as global. ID: ", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("#checkpoint", Value);
			DKNJGHFLAIF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1690f, 718f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("SaveMapButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1717f)
			{
				HBJJOCHGOPH = 1892f;
			}
			NBPKMLMCHFN.SetFloat("/?page=ranks", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("PossibleMapPointsText", Value);
			PHGCJOPFDOG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 596f, 568f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void GCHBGCGBMCK()
	{
	}

	private void BKIGIIINEDH()
	{
		SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NEKCPLGFOFD()
	{
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("CameraFilterPack/Gradients_ElectricGradient");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ANKIJGCGCBF()
	{
	}

	private void HOMNAHDDNHJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 985f)
			{
				HBJJOCHGOPH = 1530f;
			}
			LPDOGGFOBDH().SetFloat("scene ", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_TimeX", Value);
			LENEJAGLCNL().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 35f, 524f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 471f)
			{
				HBJJOCHGOPH = 559f;
			}
			LONNIJMNKFB().SetFloat("GlassesColor", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", Value);
			CECJJMKLEAK().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 285f, 940f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 524f)
			{
				HBJJOCHGOPH = 1438f;
			}
			MCDGIILBNIF().SetFloat("CameraFilterPack_3D_Matrix1", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("BadgeText", Value);
			HEINDEMCGIK().SetVector("Hidden/TonemappingColorGrading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 422f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	private void FABKIGNFECE()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find(". Prefab must have a PhotonView component.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 211f)
			{
				HBJJOCHGOPH = 163f;
			}
			LENEJAGLCNL().SetFloat("#tryagain", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_Value4", Value);
			JIBOKBCPDLC().SetVector("player.xp", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1808f, 353f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1731f)
			{
				HBJJOCHGOPH = 138f;
			}
			LONNIJMNKFB().SetFloat("{0:0} day{1}, ", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("AudioSampler", Value);
			KOHGPKOFEJO().SetVector("PopulateMapsList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1130f, 176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 781f)
			{
				HBJJOCHGOPH = 1540f;
			}
			IFMAPIDFNLI().SetFloat("float,40", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat(".lastCheckpoint.playerdistance", Value);
			MLMKCOINOOH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1173f, 1905f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1766f)
			{
				HBJJOCHGOPH = 455f;
			}
			KDMBOKLMADJ().SetFloat("RT", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("\n", Value);
			HEINDEMCGIK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1941f, 957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("Error: Someone else(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void CKECPMDEBLL()
	{
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 701f)
			{
				HBJJOCHGOPH = 1416f;
			}
			EJDPNJAEAKJ().SetFloat("[PlayerBase] Checkpoint error: ", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("<b>Time</b>:", Value);
			OJMHIMIPKME().SetVector("Default UI Material", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1304f, 1354f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 454f)
			{
				HBJJOCHGOPH = 1716f;
			}
			PHGCJOPFDOG().SetFloat("_TimeX", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("/", Value);
			KDMBOKLMADJ().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 756f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEMGPJDJGBJ()
	{
		SCShader = Shader.Find("LastHighScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Value", Value);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJCOELHNLJE()
	{
	}

	private void BEKMLIFILFP()
	{
		SCShader = Shader.Find("_ScratchOffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 793f)
			{
				HBJJOCHGOPH = 1007f;
			}
			DEFBJOCJJKF().SetFloat("_EmissionColor", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("id", Value);
			DNLMFEGJJDD().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 93f, 1966f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 702f)
			{
				HBJJOCHGOPH = 1790f;
			}
			MLMKCOINOOH().SetFloat("restrictions\n\n#until: ", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_Value3", Value);
			JIBOKBCPDLC().SetVector("Hip-hop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1529f, 1969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("GlassesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("_color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1300f)
			{
				HBJJOCHGOPH = 785f;
			}
			LENEJAGLCNL().SetFloat("Map: ", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat(" not exist", Value);
			DNLMFEGJJDD().SetVector("_Glitch", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 762f, 632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("ticket");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 833f)
			{
				HBJJOCHGOPH = 994f;
			}
			LNLKMDPHDCC().SetFloat("Right", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_ScreenResolution", Value);
			HEINDEMCGIK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1227f, 53f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABHEJPAGNMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CIHGFHNNFEE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1020f)
			{
				HBJJOCHGOPH = 271f;
			}
			OJMHIMIPKME().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("UseScanLineSize", Value);
			EJDPNJAEAKJ().SetVector("Overlay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 339f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNCLKHOEGDK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMIEAGOFLBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1110f)
			{
				HBJJOCHGOPH = 273f;
			}
			MLMKCOINOOH().SetFloat("ControllerRightY", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("Up", Value);
			MCDGIILBNIF().SetVector("win", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 897f, 28f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void IBJIBLHJKMG()
	{
		SCShader = Shader.Find("[ResourcesManager] Load image error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFECEKPFOEM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJHBFAFOEEN()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1938f)
			{
				HBJJOCHGOPH = 97f;
			}
			LPDOGGFOBDH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat(": ", Value);
			OJMHIMIPKME().SetVector("InstantiateRpc", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1520f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Ascii");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1717f)
			{
				HBJJOCHGOPH = 929f;
			}
			CECJJMKLEAK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("#,0.00", Value);
			JIBOKBCPDLC().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 991f, 669f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find("CurrentTimeLabel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 969f)
			{
				HBJJOCHGOPH = 24f;
			}
			HEINDEMCGIK().SetFloat("_Value2", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("id", Value);
			HEINDEMCGIK().SetVector("DPADHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1603f)
			{
				HBJJOCHGOPH = 1285f;
			}
			MCDGIILBNIF().SetFloat("CameraFilterPack/Blend2Camera_Blend", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Vintage", Value);
			IFMAPIDFNLI().SetVector("CameraFilterPack/Blend2Camera_Multiply", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1677f, 386f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NHHCGPAMLAJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1386f)
			{
				HBJJOCHGOPH = 504f;
			}
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_TimeX", Value);
			MCDGIILBNIF().SetVector(" Message: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1763f, 348f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 305f)
			{
				HBJJOCHGOPH = 212f;
			}
			ECCPAOBFDKP().SetFloat("<color=#{0}>{1}</color>", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("HPToggle", Value);
			LONNIJMNKFB().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 211f, 1938f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OBDEJFCNOBF()
	{
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1225f)
			{
				HBJJOCHGOPH = 286f;
			}
			EJDPNJAEAKJ().SetFloat("note.5", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blur_Dithering2x2", Value);
			ECCPAOBFDKP().SetVector("The given 2D texture ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1511f, 1053f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LKJMIODJGCM()
	{
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GCDLIKEDMCF()
	{
	}

	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1614f)
			{
				HBJJOCHGOPH = 1601f;
			}
			OJMHIMIPKME().SetFloat("workshop.", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("maps.", Value);
			HEINDEMCGIK().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1637f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1486f)
			{
				HBJJOCHGOPH = 802f;
			}
			NBPKMLMCHFN.SetFloat("_Visualize", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Edge_Sobel", Value);
			LONNIJMNKFB().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1014f, 197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("ChatHistoryInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 881f)
			{
				HBJJOCHGOPH = 1954f;
			}
			DEFBJOCJJKF().SetFloat("note.3", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_CenterRadius", Value);
			DKNJGHFLAIF().SetVector(".lastCheckpoint.checkpointsUsed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1816f, 1955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PCIMPDNLCHH()
	{
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("CameraFilterPack/Noise_TV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("CreateRoom failed, client stays on masterserver: {0}.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find(" SecondsBeforeRespawn: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void APKNAPHOFHC()
	{
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1657f)
			{
				HBJJOCHGOPH = 1162f;
			}
			KDMBOKLMADJ().SetFloat("threshold", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_Value2", Value);
			EJDPNJAEAKJ().SetVector("/icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1766f, 471f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1565f)
			{
				HBJJOCHGOPH = 1472f;
			}
			MLMKCOINOOH().SetFloat("CameraFilterPack/TV_ARCADE_2", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("SetBGColor", Value);
			OJMHIMIPKME().SetVector("ShowSprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1248f, 962f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMKBLLMIKAB()
	{
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 445f)
			{
				HBJJOCHGOPH = 96f;
			}
			NBPKMLMCHFN.SetFloat("settings.arcsnohitsoundtimedelay", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_MainTex2", Value);
			OJMHIMIPKME().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 652f, 75f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGJJDKENBNC()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Flush");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find(" scene view IDs from last level.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("Backward");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKKJICPMPHK()
	{
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("CameraFilterPack/Light_Rainbow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JFJLGJEPEAA()
	{
		SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("_Value8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNJIHCLODK()
	{
	}

	private void JBMBNKOOENB()
	{
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void PGMMBADJIKH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
