// CameraFilterPack_Blur_Radial
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Radial")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Radial : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-0.5f, 0.5f)]
	public float Intensity = 0.125f;

	[Range(-2f, 2f)]
	public float MovX = 0.5f;

	[Range(-2f, 2f)]
	public float MovY = 0.5f;

	[Range(0f, 10f)]
	private float KJIKOEIAENF = 1f;

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

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1518f)
			{
				HBJJOCHGOPH = 176f;
			}
			EOCCJGIGEGJ().SetFloat("player.goldcrystal", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Intensity);
			OLHDPICFBOF().SetFloat("_OffsetScale", MovX);
			OGMEGHKECAH().SetFloat("SetSatelliteRotationSpeed", MovY);
			KEMAALEODNH().SetFloat("/", KJIKOEIAENF);
			HEHKGPKLAKK().SetVector("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1457f, 807f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void POJFHDFJOPE()
	{
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1184f)
			{
				HBJJOCHGOPH = 971f;
			}
			HEHKGPKLAKK().SetFloat("_Value2", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("SetSunMaxSize", Intensity);
			HKGAONMOBMH().SetFloat("OperationResponse unhandled: {0}", MovX);
			PDEAHJPOMEF().SetFloat("finished", MovY);
			KDMBOKLMADJ().SetFloat("\\", KJIKOEIAENF);
			GBFOAHKAJEK().SetVector("PopulateMapsList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 427f, 1970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return BJFKDHHMLJH;
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 134f)
			{
				HBJJOCHGOPH = 796f;
			}
			LPDOGGFOBDH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("Anime", Intensity);
			FLOHGDECHHH().SetFloat("_NoisePerChannel", MovX);
			NLFJGMBCICG().SetFloat("_Value4", MovY);
			FLOHGDECHHH().SetFloat("SetSatelliteRotationSpeed", KJIKOEIAENF);
			LDNADDJMIPK().SetVector("_Red_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1038f, 1390f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 489f)
			{
				HBJJOCHGOPH = 1765f;
			}
			OCHJIMJNEMO().SetFloat("[PlayerBase] Config error: musicTime <= 0", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value5", Intensity);
			EJDPNJAEAKJ().SetFloat("menu.selectedplaymode", MovX);
			KEMAALEODNH().SetFloat("VoteDownToggle", MovY);
			FOOCJIDNGBB().SetFloat("Error0", KJIKOEIAENF);
			OGMEGHKECAH().SetVector("TBD", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1596f, 480f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("SetSunEmission");
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

	private void HIPBNBKNICE()
	{
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 15f)
			{
				HBJJOCHGOPH = 0f;
			}
			KDMBOKLMADJ().SetFloat("#no", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("maps.", Intensity);
			EFDEIFCDAFG().SetFloat("Sending vacant view IDs. Length: ", MovX);
			KEMAALEODNH().SetFloat("_Speed", MovY);
			LDNADDJMIPK().SetFloat("_MainTex2", KJIKOEIAENF);
			EFDEIFCDAFG().SetVector("CameraFilterPack/Lut_Simple", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1018f, 1132f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void INLDEHPAMJC()
	{
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("#checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1944f)
			{
				HBJJOCHGOPH = 937f;
			}
			EJDPNJAEAKJ().SetFloat("AccuracyScoreText", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("_TimeX", Intensity);
			OCHJIMJNEMO().SetFloat("BitsData", MovX);
			HEHKGPKLAKK().SetFloat("ControllerRightX", MovY);
			KEMJNOMIPHN().SetFloat("Error! no audio sources attached to AudioSampler.css", KJIKOEIAENF);
			MNLKBFFKHIE().SetVector("Joystick1Button12", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 420f, 1676f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("CameraFilterPack/Oculus_ThermaVision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BKGJOECFMID()
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

	private void JBCNIPJDPJB()
	{
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1879f)
			{
				HBJJOCHGOPH = 1126f;
			}
			KEMJNOMIPHN().SetFloat("_FixDistance", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("player.linea", Intensity);
			EJDPNJAEAKJ().SetFloat(" has no method \"", MovX);
			LPDOGGFOBDH().SetFloat("CONTRAST", MovY);
			HKGAONMOBMH().SetFloat("float,1.5", KJIKOEIAENF);
			HEHKGPKLAKK().SetVector("[LocalizationService] All languages: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 821f, 1203f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Radial");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("Fake");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("cancel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find(" Time: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1039f)
			{
				HBJJOCHGOPH = 304f;
			}
			PDEAHJPOMEF().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat(" now: ", Intensity);
			GBFOAHKAJEK().SetFloat("_TimeX", MovX);
			LDNADDJMIPK().SetFloat("_ColorR", MovY);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Special_Bubble", KJIKOEIAENF);
			EFDEIFCDAFG().SetVector("_Val2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 386f, 491f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1801f)
			{
				HBJJOCHGOPH = 1148f;
			}
			ADGHJOHKEHG().SetFloat("CameraFilterPack/Drawing_CellShading", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat("SubmitUserVote:", Intensity);
			LPDOGGFOBDH().SetFloat("Received OnSerialization for view ID ", MovX);
			GBFOAHKAJEK().SetFloat("OnReadyClick", MovY);
			OCHJIMJNEMO().SetFloat("TimeBGSlider", KJIKOEIAENF);
			HKHBBBFLGJH().SetVector(".lastCheckpoint.powerupsScore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 256f, 110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFECEKPFOEM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 475f)
			{
				HBJJOCHGOPH = 1463f;
			}
			FOOCJIDNGBB().SetFloat("RecieveChatActionMessage", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Far", Intensity);
			EFDEIFCDAFG().SetFloat("_TimeX", MovX);
			OLHDPICFBOF().SetFloat("_Value", MovY);
			DONENAMLFLF().SetFloat("_Value", KJIKOEIAENF);
			HNFFHCLNBDN().SetVector("skins", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 84f, 360f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HEBOIFKBLGD()
	{
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 192f)
			{
				HBJJOCHGOPH = 759f;
			}
			OJMHIMIPKME().SetFloat("_Value", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("Committing changes...", Intensity);
			LDNADDJMIPK().SetFloat("_HeightParams", MovX);
			LDNADDJMIPK().SetFloat("id", MovY);
			FLOHGDECHHH().SetFloat("Chat", KJIKOEIAENF);
			KEMJNOMIPHN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1750f, 370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("player.linea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1559f)
			{
				HBJJOCHGOPH = 779f;
			}
			MNLKBFFKHIE().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("/../", Intensity);
			DONENAMLFLF().SetFloat("z", MovX);
			NLFJGMBCICG().SetFloat("_Value", MovY);
			EOCCJGIGEGJ().SetFloat("offsets", KJIKOEIAENF);
			MNLKBFFKHIE().SetVector("CameraFilterPack/OldFilm_Cutting2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 734f, 314f));
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
			NBPKMLMCHFN.SetFloat("_Value", Intensity);
			NBPKMLMCHFN.SetFloat("_Value2", MovX);
			NBPKMLMCHFN.SetFloat("_Value3", MovY);
			NBPKMLMCHFN.SetFloat("_Value4", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void OHIJGCLBMJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("Missing shader for image effect {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COMNAPAAPDO()
	{
	}

	private void POEMOLBJDLG()
	{
	}

	private void IBFJAOINHMK()
	{
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("<b>(╯°□°）╯︵ ┻━┻</b>");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 637f)
			{
				HBJJOCHGOPH = 580f;
			}
			KDMBOKLMADJ().SetFloat("LevelEditor/patterns", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("MenuScene", Intensity);
			HKHBBBFLGJH().SetFloat("offsets", MovX);
			NLFJGMBCICG().SetFloat("DPADHOR", MovY);
			EOCCJGIGEGJ().SetFloat("ArcsDestroyDelaySlider", KJIKOEIAENF);
			KEMJNOMIPHN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 941f, 1693f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1664f)
			{
				HBJJOCHGOPH = 972f;
			}
			GBFOAHKAJEK().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("_Value4", Intensity);
			IGKFMCPDNOI().SetFloat("DPADHOR", MovX);
			OLHDPICFBOF().SetFloat("color", MovY);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", KJIKOEIAENF);
			OJMHIMIPKME().SetVector("UseFinalGlassColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1054f, 422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1237f)
			{
				HBJJOCHGOPH = 200f;
			}
			NBPKMLMCHFN.SetFloat(" argument(s): ", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("settings_bindings_", Intensity);
			NBPKMLMCHFN.SetFloat("skin.hit_wrong", MovX);
			EJDPNJAEAKJ().SetFloat("_Value", MovY);
			KEMJNOMIPHN().SetFloat("_Gain", KJIKOEIAENF);
			GBFOAHKAJEK().SetVector("skin.no_hit", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1950f, 1154f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 821f)
			{
				HBJJOCHGOPH = 1958f;
			}
			MNLKBFFKHIE().SetFloat("DPADHOR", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("_Value4", Intensity);
			PDEAHJPOMEF().SetFloat("_Value", MovX);
			HEHKGPKLAKK().SetFloat("SelectorMapsCountSlider", MovY);
			EFDEIFCDAFG().SetFloat("Scene", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1794f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void NEFHGMNAPEP()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Rgb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("MapperNameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 473f)
			{
				HBJJOCHGOPH = 895f;
			}
			EFDEIFCDAFG().SetFloat("PublishMapButton", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("[MapsEditor] Creating new item...", Intensity);
			LDNADDJMIPK().SetFloat("OpLeaveLobby()", MovX);
			LELKBCALFCF().SetFloat("#mapnotloaded", MovY);
			OGMEGHKECAH().SetFloat("_Value", KJIKOEIAENF);
			ADGHJOHKEHG().SetVector("_Distance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 962f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GFACKFCEIBC()
	{
	}

	[SpecialName]
	private Material GBFOAHKAJEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void LLDHEJIEDHO()
	{
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find("{0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("TotalHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 319f)
			{
				HBJJOCHGOPH = 1084f;
			}
			GBFOAHKAJEK().SetFloat("JoinButton", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat(". Our prefix is ", Intensity);
			HKHBBBFLGJH().SetFloat("_LrDepthTex", MovX);
			OGMEGHKECAH().SetFloat("_RayStepSize", MovY);
			NLFJGMBCICG().SetFloat("ItemsCountText", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1884f, 473f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("LeaderboardsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 230f)
			{
				HBJJOCHGOPH = 1600f;
			}
			OCHJIMJNEMO().SetFloat("SpectateButton", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("L2", Intensity);
			OCHJIMJNEMO().SetFloat("RarityImage", MovX);
			OLHDPICFBOF().SetFloat("_Value4", MovY);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Glasses_On", KJIKOEIAENF);
			KEMAALEODNH().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1972f, 1751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEADNKJPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 978f)
			{
				HBJJOCHGOPH = 1481f;
			}
			LDNADDJMIPK().SetFloat("FreqVolume: ", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat(" ", Intensity);
			EFDEIFCDAFG().SetFloat("A", MovX);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", MovY);
			LDNADDJMIPK().SetFloat(",", KJIKOEIAENF);
			KDMBOKLMADJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 787f, 1890f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMPHNFPPEHO()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("Default UI Material");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1124f)
			{
				HBJJOCHGOPH = 628f;
			}
			OCHJIMJNEMO().SetFloat("[MapsData] Unsubscribe ", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("OnDeserialize", Intensity);
			LPDOGGFOBDH().SetFloat("Object ID. Case-Sensitive", MovX);
			HKGAONMOBMH().SetFloat("_SSAO", MovY);
			MNLKBFFKHIE().SetFloat("_TimeX", KJIKOEIAENF);
			EOCCJGIGEGJ().SetVector("[UI] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1481f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOLDLDLFFLM()
	{
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 790f)
			{
				HBJJOCHGOPH = 1125f;
			}
			KEMAALEODNH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("ready", Intensity);
			KEMJNOMIPHN().SetFloat("_Green_B", MovX);
			ADGHJOHKEHG().SetFloat("settings.hitvariation", MovY);
			HKGAONMOBMH().SetFloat("Subscribe: ", KJIKOEIAENF);
			ADGHJOHKEHG().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 112f, 1535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return BJFKDHHMLJH;
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void NDDNJNCINDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 952f)
			{
				HBJJOCHGOPH = 205f;
			}
			DONENAMLFLF().SetFloat("0.00", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("settings.enablehitsoundsinnormal", Intensity);
			OGMEGHKECAH().SetFloat("_CenterX", MovX);
			HKHBBBFLGJH().SetFloat("_MaxBlurRadius", MovY);
			OLHDPICFBOF().SetFloat("ItemsUploader", KJIKOEIAENF);
			IGKFMCPDNOI().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 148f, 130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("menu.copyright");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BOPKKCAFODF()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void PNLKFANNOKO()
	{
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBPCODPOJAH()
	{
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1103f)
			{
				HBJJOCHGOPH = 1078f;
			}
			IGKFMCPDNOI().SetFloat("menu.enableselectormusic", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/Blend2Camera_Lighten", Intensity);
			KEMJNOMIPHN().SetFloat(".lastCheckpoint.checkpointsUsed", MovX);
			LDNADDJMIPK().SetFloat("_Far", MovY);
			LELKBCALFCF().SetFloat("y", KJIKOEIAENF);
			EJDPNJAEAKJ().SetVector("Circle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 482f, 282f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find(". Not connectedAndReady.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void OGJJDKENBNC()
	{
		SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBMDHDBELEK()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void KFMEAMBLODG()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FAKGFMFAPDG()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBIOIEANMGI()
	{
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1260f)
			{
				HBJJOCHGOPH = 259f;
			}
			EFDEIFCDAFG().SetFloat("ScrollPanel", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("R:", Intensity);
			NLFJGMBCICG().SetFloat("Vertical", MovX);
			KDMBOKLMADJ().SetFloat("players", MovY);
			KEMJNOMIPHN().SetFloat("Netw. Sim.", KJIKOEIAENF);
			DONENAMLFLF().SetVector("_Red_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 1530f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CPCDFMMLHLO()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Half_Sphere");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1557f)
			{
				HBJJOCHGOPH = 510f;
			}
			OJMHIMIPKME().SetFloat("_UserLutTex", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("USE_CORNER_DETECTION", Intensity);
			NLFJGMBCICG().SetFloat("MapperNameText", MovX);
			PDEAHJPOMEF().SetFloat("finished", MovY);
			ADGHJOHKEHG().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", KJIKOEIAENF);
			OJMHIMIPKME().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 635f, 249f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}
}
