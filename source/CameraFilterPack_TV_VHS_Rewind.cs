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
		SCShader = Shader.Find("_MaxRadiusOrKInPaper");
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
			CFEDGDGBCHE().SetFloat("_Near", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_Red_R", Cryptage);
			JFDGLLEOPGB().SetFloat("cmd.exe", Parasite);
			JIBOKBCPDLC().SetFloat("SetSatelliteSensitivity", Parasite2);
			BFGNMFCNDBC().SetFloat("player.xp", FIOHJEJCGAK);
			DKKBFFHBHJE().SetVector(".lastCheckpoint.bgcolor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 284f, 1295f));
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
		SCShader = Shader.Find("RoomDescriptionText");
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
		SCShader = Shader.Find("editorVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("USE_CORNER_DETECTION");
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
		SCShader = Shader.Find("white");
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
			LPCHMEKDCHI().SetFloat("/?player=", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(", data: ", Cryptage);
			LPCHMEKDCHI().SetFloat("_Value", Parasite);
			EOCCJGIGEGJ().SetFloat("settings.volume.editor", Parasite2);
			KJMECMIGJJA().SetFloat("_ScreenResolution", FIOHJEJCGAK);
			OLHDPICFBOF().SetVector("Uploading content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1248f, 68f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
		SCShader = Shader.Find("&map=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("settings.volume.menu");
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
			EOCCJGIGEGJ().SetFloat("CameraMovementSlider", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", Cryptage);
			JIBOKBCPDLC().SetFloat("_TexelOffsetScale", Parasite);
			IGKFMCPDNOI().SetFloat("MainButton", Parasite2);
			CFEDGDGBCHE().SetFloat("SetPlayerDistance", FIOHJEJCGAK);
			JFDGLLEOPGB().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1270f, 1855f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			KJMECMIGJJA().SetFloat("#tryagain", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_History2ChromaTex", Cryptage);
			BFGNMFCNDBC().SetFloat("settings.cameramovements", Parasite);
			NBPKMLMCHFN.SetFloat("/files/mods_terms.pdf", Parasite2);
			BFGNMFCNDBC().SetFloat("BlockSize", FIOHJEJCGAK);
			OKJOKHGJHGF().SetVector("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 35f, 1493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_BlurVector");
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
			OLHDPICFBOF().SetFloat("_Value3", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("ConfigVersionSlider", Cryptage);
			KAFBNOBOIAJ().SetFloat("RestartButton", Parasite);
			OKJOKHGJHGF().SetFloat("-1", Parasite2);
			EOCCJGIGEGJ().SetFloat("RecieveChatMessage", FIOHJEJCGAK);
			BFGNMFCNDBC().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 813f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			IIJMIPBMMBF().SetFloat("RateButton", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("Exception while connecting to: ", Cryptage);
			JFDGLLEOPGB().SetFloat("_BlurArea", Parasite);
			OKJOKHGJHGF().SetFloat("_MainTex2", Parasite2);
			IGKFMCPDNOI().SetFloat("Could not execute RPC ", FIOHJEJCGAK);
			JIBOKBCPDLC().SetVector("_MainTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 209f, 1027f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("_Value3");
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
			HKHBBBFLGJH().SetFloat("_", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("[PlayerController] ", Cryptage);
			JFDGLLEOPGB().SetFloat("SpawnObj", Parasite);
			LPCHMEKDCHI().SetFloat("settings_bindings_sec_", Parasite2);
			IIJMIPBMMBF().SetFloat("ChatHistoryInputField", FIOHJEJCGAK);
			JFDGLLEOPGB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 569f, 1166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			IIJMIPBMMBF().SetFloat("_TimeX", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("#tryagain", Cryptage);
			CEKJODEAMGB().SetFloat("#", Parasite);
			DKKBFFHBHJE().SetFloat("Joystick1Button3", Parasite2);
			KAFBNOBOIAJ().SetFloat("_Near", FIOHJEJCGAK);
			NBPKMLMCHFN.SetVector("ItemNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 587f, 79f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find(".lastCheckpoint.lives");
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
			NBPKMLMCHFN.SetFloat(":\n", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("HPToggle", Cryptage);
			JFDGLLEOPGB().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", Parasite);
			LPCHMEKDCHI().SetFloat("_TimeX", Parasite2);
			DKKBFFHBHJE().SetFloat("Run a command for data system", FIOHJEJCGAK);
			OLHDPICFBOF().SetVector("SetSatelliteRadius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 673f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			JIBOKBCPDLC().SetFloat("/files/editor_manual.pdf", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("settings.hideui", Cryptage);
			OLHDPICFBOF().SetFloat("Return: ", Parasite);
			IGKFMCPDNOI().SetFloat("_Value", Parasite2);
			LPCHMEKDCHI().SetFloat("PopulateMapsList", FIOHJEJCGAK);
			IIJMIPBMMBF().SetVector("player.linea", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1704f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");
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
			HKHBBBFLGJH().SetFloat("ShineEffect", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("JoinRandom failed: {0}.", Cryptage);
			OKJOKHGJHGF().SetFloat("float,10", Parasite);
			DKKBFFHBHJE().SetFloat("SetSatelliteColor", Parasite2);
			NBPKMLMCHFN.SetFloat("inventory.itemscash", FIOHJEJCGAK);
			HKHBBBFLGJH().SetVector("Call ConnectToNameServer to ping available regions.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1349f, 1693f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			IGKFMCPDNOI().SetFloat("mapselector.filter.rateduponly", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("CameraFilterPack_RainFX_Anm", Cryptage);
			IIJMIPBMMBF().SetFloat("#pleasewait", Parasite);
			IIJMIPBMMBF().SetFloat("[DiscordController] Disconnect {0}: {1}", Parasite2);
			EHDJJANLINB().SetFloat("config.txt", FIOHJEJCGAK);
			IIJMIPBMMBF().SetVector("0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1078f, 596f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			NBPKMLMCHFN.SetFloat("Failed to Destroy objects of playerId: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value2", Cryptage);
			OKJOKHGJHGF().SetFloat("_Value", Parasite);
			KJMECMIGJJA().SetFloat("#score", Parasite2);
			LPCHMEKDCHI().SetFloat("OpGetGameList not sent. Lobby cannot be null.", FIOHJEJCGAK);
			OKJOKHGJHGF().SetVector("_SceneFogParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1865f, 645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("checkpoint");
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
			CEKJODEAMGB().SetFloat("_Value3", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat(" beatThreshold: ", Cryptage);
			EHDJJANLINB().SetFloat("_ScreenResolution", Parasite);
			JFDGLLEOPGB().SetFloat("CheckpointsScoreText", Parasite2);
			DKKBFFHBHJE().SetFloat("id", FIOHJEJCGAK);
			LPCHMEKDCHI().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 621f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			KBOPGONOCNP().SetFloat("Added checkpoint", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", Cryptage);
			NBPKMLMCHFN.SetFloat("GraphicsQualitySlider", Parasite);
			EOCCJGIGEGJ().SetFloat("settings.shaders.bloomintencity", Parasite2);
			CFEDGDGBCHE().SetFloat("3;4;9;10;21x6", FIOHJEJCGAK);
			OLHDPICFBOF().SetVector("Set particles count per one beat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1867f, 1775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			HKHBBBFLGJH().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("PUNCloudBestRegion", Cryptage);
			EHDJJANLINB().SetFloat("_TimeX", Parasite);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", Parasite2);
			DKKBFFHBHJE().SetFloat("{0} seconds ago", FIOHJEJCGAK);
			IIJMIPBMMBF().SetVector("_Noise", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 919f, 180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
