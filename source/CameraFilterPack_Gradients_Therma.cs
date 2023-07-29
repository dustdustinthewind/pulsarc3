// CameraFilterPack_Gradients_Therma
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Gradients/Thermal")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_Therma : MonoBehaviour
{
	public Shader SCShader;

	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Therma";

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Switch = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void AGMJDGHLBMN()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODGMCJILIHF()
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

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 264f)
			{
				HBJJOCHGOPH = 1128f;
			}
			LPMLLJKMAMP().SetFloat("_MainTex2", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_Value7", Switch);
			ABHDNGIHBKE().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", Fade);
			GCDFNHMJMIP().SetVector("EndlessLoopsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1729f, 1254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1970f)
			{
				HBJJOCHGOPH = 241f;
			}
			ABHDNGIHBKE().SetFloat(" : ", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("player.bluelifering", Switch);
			PLBEJJIHFPB().SetFloat("VoteDownToggle", Fade);
			CEKJODEAMGB().SetVector("MenuScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1643f, 566f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 77f)
			{
				HBJJOCHGOPH = 892f;
			}
			HNICHJCGJOC().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_ChromaticAberration", Switch);
			PDEAHJPOMEF().SetFloat("clicked ", Fade);
			FEAEGGCNIAA().SetVector("checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 824f, 927f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 643f)
			{
				HBJJOCHGOPH = 786f;
			}
			NBMPPNFKFLB().SetFloat("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("EventTimeInputField", Switch);
			NBMPPNFKFLB().SetFloat("Failed to 'network-remove' GameObject because it's null.", Fade);
			CEKJODEAMGB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1266f, 266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			if (HBJJOCHGOPH > 665f)
			{
				HBJJOCHGOPH = 1050f;
			}
			FEAEGGCNIAA().SetFloat("_TimeX", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_ScreenResolution", Switch);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Fade);
			NBMPPNFKFLB().SetVector("http://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1933f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 670f)
			{
				HBJJOCHGOPH = 831f;
			}
			LPMLLJKMAMP().SetFloat("_TimeX", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("Fade", Switch);
			NBPKMLMCHFN.SetFloat("_TimeX", Fade);
			CEKJODEAMGB().SetVector("<color=#{0}>{1}</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1833f, 1642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 552f)
			{
				HBJJOCHGOPH = 694f;
			}
			GCDFNHMJMIP().SetFloat("SaveButton", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("finished", Switch);
			PDEAHJPOMEF().SetFloat("sprite", Fade);
			AELJLBOJAIL().SetVector("EventData0DropDownList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1340f, 1029f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 889f)
			{
				HBJJOCHGOPH = 402f;
			}
			ABHDNGIHBKE().SetFloat("_Value", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("IntraTime", Switch);
			FLOHGDECHHH().SetFloat("_Value3", Fade);
			PLBEJJIHFPB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1648f, 1983f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 991f)
			{
				HBJJOCHGOPH = 1155f;
			}
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Edge_Golden", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("RPCs can only be sent in rooms. Call of \"", Switch);
			NBMPPNFKFLB().SetFloat("_NeighborMaxTex", Fade);
			NDMPCDHADMJ().SetVector("AudioSampler", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 979f, 1723f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GMELGGJOPBB()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 893f)
			{
				HBJJOCHGOPH = 1317f;
			}
			NDMPCDHADMJ().SetFloat("_TimeX", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Fade", Switch);
			FEAEGGCNIAA().SetFloat("speed", Fade);
			NBMPPNFKFLB().SetVector("LevelEditor/CustomEventEditor-", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 520f, 967f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 616f)
			{
				HBJJOCHGOPH = 1420f;
			}
			FLOHGDECHHH().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("_Value7", Switch);
			NBPKMLMCHFN.SetFloat("y", Fade);
			AELJLBOJAIL().SetVector("_SprTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 635f, 193f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1636f)
			{
				HBJJOCHGOPH = 579f;
			}
			KEMAALEODNH().SetFloat("AVG Misses:", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_Red_C", Switch);
			AELJLBOJAIL().SetFloat("_ScreenResolution", Fade);
			HNICHJCGJOC().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 817f, 354f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1040f)
			{
				HBJJOCHGOPH = 865f;
			}
			NBMPPNFKFLB().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("CrosshairOpacitySlider", Switch);
			GCDFNHMJMIP().SetFloat("float", Fade);
			NBMPPNFKFLB().SetVector("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1522f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HMNLHMLILKD()
	{
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void POIMNOBDBBN()
	{
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Switch);
			NBPKMLMCHFN.SetFloat("_Value2", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1427f)
			{
				HBJJOCHGOPH = 1144f;
			}
			AELJLBOJAIL().SetFloat("float,0", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("BadgeText", Switch);
			BFGNMFCNDBC().SetFloat("Joystick1Button2", Fade);
			CEKJODEAMGB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 492f, 1600f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 68f)
			{
				HBJJOCHGOPH = 328f;
			}
			FEAEGGCNIAA().SetFloat("#tryagain", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("event", Switch);
			AELJLBOJAIL().SetFloat("_TimeX", Fade);
			EPCGJFCCAFH().SetVector("11", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1966f, 688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 765f)
			{
				HBJJOCHGOPH = 1135f;
			}
			FEAEGGCNIAA().SetFloat("GridDataStoryboard", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Value4", Switch);
			FEAEGGCNIAA().SetFloat(" not exist", Fade);
			NBPKMLMCHFN.SetVector("_Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 503f, 433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 135f)
			{
				HBJJOCHGOPH = 1864f;
			}
			AELJLBOJAIL().SetFloat("_SoftZDistance", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Blend2Camera_HardMix", Switch);
			EPCGJFCCAFH().SetFloat("EventData0DropDownList", Fade);
			BFGNMFCNDBC().SetVector("Obtain test Item", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 15f, 1308f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void MMMDPANNAIO()
	{
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
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1317f)
			{
				HBJJOCHGOPH = 985f;
			}
			NBMPPNFKFLB().SetFloat("DifficultyBG", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("[MapEditor] Updating top menu", Switch);
			AELJLBOJAIL().SetFloat("id", Fade);
			ABHDNGIHBKE().SetVector("Loss ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 956f, 1493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 318f)
			{
				HBJJOCHGOPH = 600f;
			}
			CEKJODEAMGB().SetFloat("RB", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Fade", Switch);
			PLBEJJIHFPB().SetFloat("maphash", Fade);
			NBMPPNFKFLB().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 7f, 1934f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1316f)
			{
				HBJJOCHGOPH = 926f;
			}
			GCDFNHMJMIP().SetFloat("#ok", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat(" ", Switch);
			FLOHGDECHHH().SetFloat("_MainTex2", Fade);
			BFGNMFCNDBC().SetVector("_SSAO", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 739f, 387f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1431f)
			{
				HBJJOCHGOPH = 1721f;
			}
			EPCGJFCCAFH().SetFloat("Set sun beat detection sensitivity", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_ContrastGainGamma", Switch);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", Fade);
			NBPKMLMCHFN.SetVector("11", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 223f, 1351f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void EJFJENFKLND()
	{
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1657f)
			{
				HBJJOCHGOPH = 443f;
			}
			CEKJODEAMGB().SetFloat("challenges/", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("maps.", Switch);
			BFGNMFCNDBC().SetFloat("_NeighbourMaxTex", Fade);
			FEAEGGCNIAA().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 855f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void AEEGKLABFLN()
	{
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBCNIPJDPJB()
	{
	}
}
