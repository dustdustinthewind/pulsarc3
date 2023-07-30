// CameraFilterPack_Color_YUV
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Colors/Color_YUV")]
public class CameraFilterPack_Color_YUV : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-1f, 1f)]
	public float _Y;

	[Range(-1f, 1f)]
	public float _U;

	[Range(-1f, 1f)]
	public float _V;

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

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 714f)
			{
				HBJJOCHGOPH = 539f;
			}
			EHDJJANLINB().SetFloat("float,0.5", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("settings.volume.sfx", _Y);
			NLFJGMBCICG().SetFloat("GroupNameText", _U);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Color_Contrast", _V);
			GJHLADDCMFF().SetVector("inventory.selected.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1582f, 1591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("[NetworkScene] Exited");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 732f)
			{
				HBJJOCHGOPH = 1394f;
			}
			EHDJJANLINB().SetFloat("SetSatelliteSensitivity", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("PLEASE WAIT", _Y);
			GJHLADDCMFF().SetFloat("_NoisePerChannel", _U);
			NLFJGMBCICG().SetFloat("#finished", _V);
			KGOLDDBHIFN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 757f, 516f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Subtract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Color_YUV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("NEW");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void KMEONPMCNJG()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 213f)
			{
				HBJJOCHGOPH = 1058f;
			}
			PLBEJJIHFPB().SetFloat("couldn't be found!", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_ScreenResolution", _Y);
			PDEAHJPOMEF().SetFloat("ItemNameText", _U);
			ABHDNGIHBKE().SetFloat("_MaxRadiusOrKInPaper", _V);
			PLBEJJIHFPB().SetVector("0 seconds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 490f)
			{
				HBJJOCHGOPH = 501f;
			}
			NLFJGMBCICG().SetFloat("0x", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_Value4", _Y);
			CEKJODEAMGB().SetFloat("There is already a virtual button named ", _U);
			NLFJGMBCICG().SetFloat("_EmissionColor", _V);
			KGOLDDBHIFN().SetVector("Hex value #RRGGBB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1516f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 127f)
			{
				HBJJOCHGOPH = 1764f;
			}
			NLFJGMBCICG().SetFloat("note.3", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("[", _Y);
			LDNADDJMIPK().SetFloat("_Green_B", _U);
			PLBEJJIHFPB().SetFloat("_NeighbourMaxTex", _V);
			PLBEJJIHFPB().SetVector("Maps Editor v.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 591f, 679f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void Update()
	{
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1335f)
			{
				HBJJOCHGOPH = 463f;
			}
			NLFJGMBCICG().SetFloat("Set sun lerp speed", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat(",viewkeys", _Y);
			PLBEJJIHFPB().SetFloat("[DiscordController] Join ({0})", _U);
			IIJMIPBMMBF().SetFloat("maps.", _V);
			PDEAHJPOMEF().SetVector("settings.gamemessagesduration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1021f, 1955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1443f)
			{
				HBJJOCHGOPH = 1294f;
			}
			OCHJIMJNEMO().SetFloat("ENABLE_COLOR_GRADING", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("null", _Y);
			PLBEJJIHFPB().SetFloat("_Value2", _U);
			EHDJJANLINB().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", _V);
			NBPKMLMCHFN.SetVector("#updateoutdatedmap", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 914f, 1867f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void BGDONBMDPGM()
	{
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("stretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("Can not SetMasterClient(). Not in room or in offlineMode.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEEGKLABFLN()
	{
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
			NBPKMLMCHFN.SetFloat("_Y", _Y);
			NBPKMLMCHFN.SetFloat("_U", _U);
			NBPKMLMCHFN.SetFloat("_V", _V);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1571f)
			{
				HBJJOCHGOPH = 1156f;
			}
			ABHDNGIHBKE().SetFloat(" argument(s): ", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Screenshots only supported in PlayMode", _Y);
			GJHLADDCMFF().SetFloat("#alreadyexist", _U);
			EHDJJANLINB().SetFloat("OPEN", _V);
			GJHLADDCMFF().SetVector("FPSToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 496f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 18f)
			{
				HBJJOCHGOPH = 491f;
			}
			IIJMIPBMMBF().SetFloat("_VelTex", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value4", _Y);
			ABHDNGIHBKE().SetFloat(". Check if the server is available.", _U);
			EHDJJANLINB().SetFloat("delete", _V);
			NLFJGMBCICG().SetVector("Scene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 434f, 1324f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 401f)
			{
				HBJJOCHGOPH = 1547f;
			}
			KGOLDDBHIFN().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("bad", _Y);
			HHIFMIPPMPF().SetFloat("SetParent", _U);
			NLFJGMBCICG().SetFloat("Error: You're not logged into Steam!", _V);
			NLFJGMBCICG().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1348f, 1616f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1503f)
			{
				HBJJOCHGOPH = 1881f;
			}
			NBPKMLMCHFN.SetFloat("float,0", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("value", _Y);
			EHDJJANLINB().SetFloat("DPADVER", _U);
			LDNADDJMIPK().SetFloat("UseFinalGlassColor", _V);
			GJHLADDCMFF().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 532f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void POIMNOBDBBN()
	{
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 782f)
			{
				HBJJOCHGOPH = 1949f;
			}
			PDEAHJPOMEF().SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("player.bat", _Y);
			IIJMIPBMMBF().SetFloat("skin.hit_wrong", _U);
			KGOLDDBHIFN().SetFloat("_SSRMultiplier", _V);
			OCHJIMJNEMO().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 903f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("reset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void AAPKBNDHBLI()
	{
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find(":</b> ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1296f)
			{
				HBJJOCHGOPH = 331f;
			}
			PDEAHJPOMEF().SetFloat("FinishMap", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat(".b", _Y);
			NBPKMLMCHFN.SetFloat("AudioSampler", _U);
			CEKJODEAMGB().SetFloat(" not exist", _V);
			KGOLDDBHIFN().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1739f, 1581f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 754f)
			{
				HBJJOCHGOPH = 1584f;
			}
			IIJMIPBMMBF().SetFloat("PerfectHitsScoreText", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("GameScene", _Y);
			PDEAHJPOMEF().SetFloat("checkpoint", _U);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Color_GrayScale", _V);
			LDNADDJMIPK().SetVector("isVisible", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1976f, 1021f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("masterSteamID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("Set particles count per one beat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("ScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1458f)
			{
				HBJJOCHGOPH = 1601f;
			}
			ABHDNGIHBKE().SetFloat("_Red_R", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Value2", _Y);
			LDNADDJMIPK().SetFloat("_Value", _U);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Pixelisation_OilPaint", _V);
			PLBEJJIHFPB().SetVector("_ColoredChange", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 136f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1060f)
			{
				HBJJOCHGOPH = 1200f;
			}
			LNLKMDPHDCC().SetFloat("Editor/", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("Please attach component to a Graphical UI component", _Y);
			LDNADDJMIPK().SetFloat("leave", _U);
			NLFJGMBCICG().SetFloat("_InternalLutTex", _V);
			LDNADDJMIPK().SetVector("USE_DIAG_SEARCH", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 743f, 371f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("closed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JAAJECBCCFM()
	{
	}
}
