// CameraFilterPack_TV_VHS_Rewind
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/VHS/VHS_Rewind")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_VHS_Rewind : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Cryptage = 1f;

	[Range(-20f, 20f)]
	public float Parasite = 9f;

	[Range(-20f, 20f)]
	public float Parasite2 = 12f;

	[Range(0f, 1f)]
	private float FIOHJEJCGAK = 1f;

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

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("(\\[ */ *quote *\\])");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("_VelocityScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void MFMIODIAKNI()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 61f)
			{
				HBJJOCHGOPH = 366f;
			}
			KJMECMIGJJA().SetFloat("_Far", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_Red_R", Cryptage);
			KBOPGONOCNP().SetFloat("cmd.exe", Parasite);
			KAFBNOBOIAJ().SetFloat("SetSatelliteSensitivity", Parasite2);
			OKJOKHGJHGF().SetFloat("Reload Steam Inventory", FIOHJEJCGAK);
			HKHBBBFLGJH().SetVector(".lastCheckpoint.time", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 284f, 1295f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EKCDEFDELMP()
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

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("roomDescription");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ONMGIPAILOH()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("setbool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("gameVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("USE_UV_BASED_REPROJECTION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("violet");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 876f)
			{
				HBJJOCHGOPH = 875f;
			}
			CFEDGDGBCHE().SetFloat("#,0", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("return ", Cryptage);
			EHDJJANLINB().SetFloat("_Value2", Parasite);
			LPCHMEKDCHI().SetFloat("SettingsCanvas", Parasite2);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/FX_Drunk2", FIOHJEJCGAK);
			OLHDPICFBOF().SetVector("PLEASE WAIT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1248f, 68f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("&page=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("action");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 318f)
			{
				HBJJOCHGOPH = 750f;
			}
			EHDJJANLINB().SetFloat("CameraMovementSlider", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Texture2", Cryptage);
			NBPKMLMCHFN.SetFloat("_SSAO", Parasite);
			CFEDGDGBCHE().SetFloat("ScrollPanel", Parasite2);
			CEKJODEAMGB().SetFloat("SpawnObj", FIOHJEJCGAK);
			KAFBNOBOIAJ().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1270f, 1855f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Cryptage);
			NBPKMLMCHFN.SetFloat("_Value2", Parasite);
			NBPKMLMCHFN.SetFloat("_Value3", Parasite2);
			NBPKMLMCHFN.SetFloat("_Value4", FIOHJEJCGAK);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1736f)
			{
				HBJJOCHGOPH = 898f;
			}
			EOCCJGIGEGJ().SetFloat("#tryagain", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_History4ChromaTex", Cryptage);
			OKJOKHGJHGF().SetFloat("settings.hitvariation", Parasite);
			KJMECMIGJJA().SetFloat("Have you fully accept the terms?", Parasite2);
			NBPKMLMCHFN.SetFloat("_SprTex", FIOHJEJCGAK);
			CFEDGDGBCHE().SetVector("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 35f, 1493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_OcclusionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1772f)
			{
				HBJJOCHGOPH = 1002f;
			}
			CFCPHFMKHII().SetFloat("_Value4", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("Tab1Content", Cryptage);
			IGKFMCPDNOI().SetFloat("RestartButton", Parasite);
			EHDJJANLINB().SetFloat("#forever", Parasite2);
			KBOPGONOCNP().SetFloat("RecieveChatMessage", FIOHJEJCGAK);
			OKJOKHGJHGF().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 813f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1915f)
			{
				HBJJOCHGOPH = 241f;
			}
			KJMECMIGJJA().SetFloat("LeaderboardsButton", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("127.0.0.1", Cryptage);
			EHDJJANLINB().SetFloat("_RangeScale", Parasite);
			JFDGLLEOPGB().SetFloat("_MainTex2", Parasite2);
			JIBOKBCPDLC().SetFloat("Error: Cannot change the name of a remote player!", FIOHJEJCGAK);
			NBPKMLMCHFN.SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 209f, 1027f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1565f)
			{
				HBJJOCHGOPH = 1485f;
			}
			HKHBBBFLGJH().SetFloat("_RgbTex", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat(": ", Cryptage);
			BFGNMFCNDBC().SetFloat("Checkpoint", Parasite);
			IIJMIPBMMBF().SetFloat("settings_bindings_sec_", Parasite2);
			CFCPHFMKHII().SetFloat("In Network lobby", FIOHJEJCGAK);
			LPCHMEKDCHI().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 569f, 1166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 619f)
			{
				HBJJOCHGOPH = 790f;
			}
			JIBOKBCPDLC().SetFloat("_Value", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("#close", Cryptage);
			KBOPGONOCNP().SetFloat(",", Parasite);
			JIBOKBCPDLC().SetFloat("Joystick1Button4", Parasite2);
			DKKBFFHBHJE().SetFloat("_Near", FIOHJEJCGAK);
			KJMECMIGJJA().SetVector("RarityImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 587f, 79f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PFNFPINPCMH()
	{
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1527f)
			{
				HBJJOCHGOPH = 1833f;
			}
			BFGNMFCNDBC().SetFloat("\n\n• ", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("HPToggle", Cryptage);
			DKKBFFHBHJE().SetFloat("ConnectToRegion: ", Parasite);
			OLHDPICFBOF().SetFloat("UseFinalGlassColor", Parasite2);
			JFDGLLEOPGB().SetFloat("<command>", FIOHJEJCGAK);
			JIBOKBCPDLC().SetVector("SetSatelliteTrailWidth", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 673f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1168f)
			{
				HBJJOCHGOPH = 1204f;
			}
			LPCHMEKDCHI().SetFloat("\nCreated by Oxy949", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Player", Cryptage);
			IGKFMCPDNOI().SetFloat("mapselector.filter.rateduponly", Parasite);
			OKJOKHGJHGF().SetFloat("_Value", Parasite2);
			EHDJJANLINB().SetFloat("EventSystem", FIOHJEJCGAK);
			OKJOKHGJHGF().SetVector("player.linea", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1704f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find(". Current number of cells is ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1143f)
			{
				HBJJOCHGOPH = 1953f;
			}
			CFEDGDGBCHE().SetFloat("UI Extensions/SoftMaskShaderText", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", Cryptage);
			KBOPGONOCNP().SetFloat("float,10", Parasite);
			IIJMIPBMMBF().SetFloat("SetSatelliteInput", Parasite2);
			JIBOKBCPDLC().SetFloat("[ItemsHandler] Item not found:", FIOHJEJCGAK);
			BFGNMFCNDBC().SetVector(" Server: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1349f, 1693f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1736f)
			{
				HBJJOCHGOPH = 586f;
			}
			OLHDPICFBOF().SetFloat("mapselector.filter.rateduponly", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("CameraFilterPack/RainFX", Cryptage);
			CFCPHFMKHII().SetFloat("steamid", Parasite);
			KAFBNOBOIAJ().SetFloat("[DiscordController] Join ({0})", Parasite2);
			KBOPGONOCNP().SetFloat("config.txt", FIOHJEJCGAK);
			IIJMIPBMMBF().SetVector("[PlayerBase] Loaded music", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1078f, 596f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1932f)
			{
				HBJJOCHGOPH = 1573f;
			}
			OKJOKHGJHGF().SetFloat("Failed to 'network-remove' GameObject because has no PhotonView components: ", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_Value4", Cryptage);
			LPCHMEKDCHI().SetFloat("_Value3", Parasite);
			KAFBNOBOIAJ().SetFloat("#lives", Parasite2);
			BFGNMFCNDBC().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", FIOHJEJCGAK);
			IIJMIPBMMBF().SetVector("_MainTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1865f, 645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("SetBGColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 240f)
			{
				HBJJOCHGOPH = 383f;
			}
			KBOPGONOCNP().SetFloat("_Speed", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat(" beatThreshold: ", Cryptage);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", Parasite);
			NBPKMLMCHFN.SetFloat("CheckpointsScoreText", Parasite2);
			OLHDPICFBOF().SetFloat("Object ID. Case-Sensitive", FIOHJEJCGAK);
			CFCPHFMKHII().SetVector("\n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 621f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("player.arrow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void OCMKCBBCEFG()
	{
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1853f)
			{
				HBJJOCHGOPH = 68f;
			}
			DKKBFFHBHJE().SetFloat("Added checkpoint", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", Cryptage);
			NBPKMLMCHFN.SetFloat("ShadersToggle", Parasite);
			KBOPGONOCNP().SetFloat("settings.fps", Parasite2);
			OKJOKHGJHGF().SetFloat("23x3", FIOHJEJCGAK);
			CFEDGDGBCHE().SetVector("Set particles count per one beat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1867f, 1775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void LBIOIEANMGI()
	{
	}

	private void LPMINJJPDCH()
	{
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 166f)
			{
				HBJJOCHGOPH = 8f;
			}
			KAFBNOBOIAJ().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat(" Server: ", Cryptage);
			LPCHMEKDCHI().SetFloat("_Value", Parasite);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Blur_Steam", Parasite2);
			KBOPGONOCNP().SetFloat("{0} seconds ago", FIOHJEJCGAK);
			EHDJJANLINB().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 919f, 180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("Error! no audio sources attached to AudioSampler.css");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material CFCPHFMKHII()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
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

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_VHS_Rewind");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
