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
			OGMEGHKECAH().SetFloat("shader.crispwinter", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Intensity);
			IGKFMCPDNOI().SetFloat("_BlurRadius", MovX);
			EOCCJGIGEGJ().SetFloat("SetSatelliteTrailLength", MovY);
			NBPKMLMCHFN.SetFloat("deletemap", KJIKOEIAENF);
			FLOHGDECHHH().SetVector("Item ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1457f, 807f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			HKGAONMOBMH().SetFloat("_Value2", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat("SetSatelliteColor", Intensity);
			IGKFMCPDNOI().SetFloat("Connected to gameserver.", MovX);
			KEMJNOMIPHN().SetFloat("finished", MovY);
			OGMEGHKECAH().SetFloat("System.String", KJIKOEIAENF);
			OLHDPICFBOF().SetVector("mapselector.filter.rateduponly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 427f, 1970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			OCHJIMJNEMO().SetFloat("CameraFilterPack/Edge_Sobel", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("Blues", Intensity);
			FLOHGDECHHH().SetFloat("_MidGrey", MovX);
			PDEAHJPOMEF().SetFloat("_Value4", MovY);
			GBFOAHKAJEK().SetFloat("SetSatelliteRotationSpeed", KJIKOEIAENF);
			IGKFMCPDNOI().SetVector("_Red_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1038f, 1390f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
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
			GBFOAHKAJEK().SetFloat("#ok", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("_ScreenResolution", Intensity);
			MNLKBFFKHIE().SetFloat("menu.selectedplaymode", MovX);
			LDNADDJMIPK().SetFloat("MenuScene", MovY);
			HNFFHCLNBDN().SetFloat("SpawnObj", KJIKOEIAENF);
			HKHBBBFLGJH().SetVector("TBD", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1596f, 480f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Set Sun Emission");
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
			NBPKMLMCHFN.SetFloat("#no", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("maps.", Intensity);
			PDEAHJPOMEF().SetFloat("Could not find RPC with index: ", MovX);
			DONENAMLFLF().SetFloat("_Speed", MovY);
			HKGAONMOBMH().SetFloat("_TimeX", KJIKOEIAENF);
			OLHDPICFBOF().SetVector("The given 2D texture ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1018f, 1132f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
		SCShader = Shader.Find("\" error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("SetSpeed");
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
			FLOHGDECHHH().SetFloat("AccuracyScoreText", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_TimeX", Intensity);
			KDMBOKLMADJ().SetFloat("SpawnObj", MovX);
			LDNADDJMIPK().SetFloat("Left", MovY);
			PDEAHJPOMEF().SetFloat("Error! no audio sources attached to AudioSampler.css", KJIKOEIAENF);
			OLHDPICFBOF().SetVector("Joystick1Button0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 420f, 1676f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
		SCShader = Shader.Find("_TimeX");
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
			OLHDPICFBOF().SetFloat("_FixDistance", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("player.deleted", Intensity);
			ADGHJOHKEHG().SetFloat("PhotonView with ID ", MovX);
			LELKBCALFCF().SetFloat("_TimeX", MovY);
			DONENAMLFLF().SetFloat("Set satellite emission (glow)", KJIKOEIAENF);
			DONENAMLFLF().SetVector(" - Contains ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 821f, 1203f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
		SCShader = Shader.Find("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.");
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
		SCShader = Shader.Find("selector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("EXCEPTION:");
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
		SCShader = Shader.Find("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.");
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
			LDNADDJMIPK().SetFloat("Item ", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat(" timeUntilRespawnBasedOnTimeBase:", Intensity);
			HKHBBBFLGJH().SetFloat("_TimeX", MovX);
			HKGAONMOBMH().SetFloat("_ColorG", MovY);
			OGMEGHKECAH().SetFloat("_TimeX", KJIKOEIAENF);
			KEMJNOMIPHN().SetVector("_Val3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 386f, 491f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			OJMHIMIPKME().SetFloat("_TimeX", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("[MapsStats] Map ID: ", Intensity);
			OCHJIMJNEMO().SetFloat("Received OnSerialization for view ID ", MovX);
			HNFFHCLNBDN().SetFloat("OnReadyClick", MovY);
			OJMHIMIPKME().SetFloat("TimeBGSlider", KJIKOEIAENF);
			OCHJIMJNEMO().SetVector(".lastCheckpoint.perfectHits", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 256f, 110f));
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
		SCShader = Shader.Find("BlockSize");
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
			NLFJGMBCICG().SetFloat("RecieveChatActionMessage", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_Far", Intensity);
			OJMHIMIPKME().SetFloat("_TimeX", MovX);
			LELKBCALFCF().SetFloat("_Value2", MovY);
			FOOCJIDNGBB().SetFloat("_Value", KJIKOEIAENF);
			KEMAALEODNH().SetVector("Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 84f, 360f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
			DONENAMLFLF().SetFloat("_Value2", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("SUCCESS! Item submitted! :D :D :D", Intensity);
			KEMAALEODNH().SetFloat("_SceneFogParams", MovX);
			EOCCJGIGEGJ().SetFloat("id", MovY);
			HEHKGPKLAKK().SetFloat("Send", KJIKOEIAENF);
			MNLKBFFKHIE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1750f, 370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
			OLHDPICFBOF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("/", Intensity);
			NBPKMLMCHFN.SetFloat("float,1", MovX);
			MNLKBFFKHIE().SetFloat("_Value2", MovY);
			NBPKMLMCHFN.SetFloat("offsets", KJIKOEIAENF);
			NLFJGMBCICG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 734f, 314f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
		SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("Depth textures aren't supported on this device ({0})");
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
			OLHDPICFBOF().SetFloat("ShowTitle", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("Bad modpack name: {0}", Intensity);
			MNLKBFFKHIE().SetFloat("stretchWidth", MovX);
			EOCCJGIGEGJ().SetFloat("DPADHOR", MovY);
			EJDPNJAEAKJ().SetFloat("ArcsDestroyDelaySlider", KJIKOEIAENF);
			HKGAONMOBMH().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 941f, 1693f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			HNFFHCLNBDN().SetFloat("ns", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_Value4", Intensity);
			ADGHJOHKEHG().SetFloat("DPADHOR", MovX);
			FOOCJIDNGBB().SetFloat("Start Color's hex value #RRGGBBAA", MovY);
			ADGHJOHKEHG().SetFloat("_MainTex2", KJIKOEIAENF);
			GBFOAHKAJEK().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1054f, 422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("CameraFilterPack/FX_Screens");
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
			HKGAONMOBMH().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("settings_bindings_sec_", Intensity);
			PDEAHJPOMEF().SetFloat("sounds/hit_perfect", MovX);
			KEMJNOMIPHN().SetFloat("_Value2", MovY);
			OLHDPICFBOF().SetFloat("_Vibrance", KJIKOEIAENF);
			KDMBOKLMADJ().SetVector("skin.no_hit", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1950f, 1154f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			DONENAMLFLF().SetFloat("DPADHOR", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("CameraFilterPack/Vision_Psycho", Intensity);
			OGMEGHKECAH().SetFloat("_Value2", MovX);
			GBFOAHKAJEK().SetFloat("settings.selectormapsperpage", MovY);
			ADGHJOHKEHG().SetFloat("HitInRelaxMusicToggle", KJIKOEIAENF);
			KDMBOKLMADJ().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1794f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("/");
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
			PDEAHJPOMEF().SetFloat("SaveMapButton", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat(".completed", Intensity);
			HEHKGPKLAKK().SetFloat("OpJoinRoom()", MovX);
			KDMBOKLMADJ().SetFloat("ViewMenu", MovY);
			OGMEGHKECAH().SetFloat("_Value2", KJIKOEIAENF);
			EFDEIFCDAFG().SetVector("_Size", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 962f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("{0:0} minute{1}, ");
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
			LELKBCALFCF().SetFloat("JoinButton", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", Intensity);
			NLFJGMBCICG().SetFloat("_FgOverlap", MovX);
			OJMHIMIPKME().SetFloat("_TreatBackfaceHitAsMiss", MovY);
			EJDPNJAEAKJ().SetFloat("ItemNameText", KJIKOEIAENF);
			OCHJIMJNEMO().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1884f, 473f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
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
			OLHDPICFBOF().SetFloat("RestartButton", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("R2", Intensity);
			OLHDPICFBOF().SetFloat("\n\n• ", MovX);
			GBFOAHKAJEK().SetFloat("_Value4", MovY);
			PDEAHJPOMEF().SetFloat("_TimeX", KJIKOEIAENF);
			HKGAONMOBMH().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1972f, 1751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			FLOHGDECHHH().SetFloat("FreqVolume: ", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat(" ", Intensity);
			KDMBOKLMADJ().SetFloat("Joystick1Button2", MovX);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Gradients_ElectricGradient", MovY);
			EJDPNJAEAKJ().SetFloat("[Left]", KJIKOEIAENF);
			HKGAONMOBMH().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 787f, 1890f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
		SCShader = Shader.Find("Please attach component to a Graphical UI component");
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
			HEHKGPKLAKK().SetFloat("/", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("Keeping GameObject in the scene: ", Intensity);
			HEHKGPKLAKK().SetFloat("Object ID. Case-Sensitive", MovX);
			KDMBOKLMADJ().SetFloat("_BlurRadius4", MovY);
			KDMBOKLMADJ().SetFloat("_Value", KJIKOEIAENF);
			MNLKBFFKHIE().SetVector("[UI] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1481f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			KDMBOKLMADJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("ready", Intensity);
			IGKFMCPDNOI().SetFloat("_Blue_R", MovX);
			NLFJGMBCICG().SetFloat("]", MovY);
			ADGHJOHKEHG().SetFloat("ticket", KJIKOEIAENF);
			KEMAALEODNH().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 112f, 1535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			NBPKMLMCHFN.SetFloat("%", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("-", Intensity);
			HEHKGPKLAKK().SetFloat("_CenterX", MovX);
			ADGHJOHKEHG().SetFloat("_TileMaxLoop", MovY);
			KEMAALEODNH().SetFloat("ItemsUploader", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 148f, 130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BOPKKCAFODF()
	{
		SCShader = Shader.Find("_Value4");
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
			EJDPNJAEAKJ().SetFloat("menu.enableselectormusic", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_MainTex2", Intensity);
			EOCCJGIGEGJ().SetFloat(".lastCheckpoint.perfectHits", MovX);
			OGMEGHKECAH().SetFloat("_Far", MovY);
			LELKBCALFCF().SetFloat("float,0", KJIKOEIAENF);
			MNLKBFFKHIE().SetVector("Triangle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 482f, 282f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("Can't SendMove. Turn is finished by this player.");
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
		SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Done");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("_Value5");
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
			MNLKBFFKHIE().SetFloat("SlidingArea", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("B:", Intensity);
			HEHKGPKLAKK().SetFloat("EventSystem", MovX);
			OCHJIMJNEMO().SetFloat("players", MovY);
			NBPKMLMCHFN.SetFloat("No peer to communicate with. ", KJIKOEIAENF);
			KDMBOKLMADJ().SetVector("_Green_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 1530f));
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
		SCShader = Shader.Find("_TimeX");
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
			OCHJIMJNEMO().SetFloat("ENABLE_USER_LUT", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("USE_UV_BASED_REPROJECTION", Intensity);
			PDEAHJPOMEF().SetFloat(" ", MovX);
			OJMHIMIPKME().SetFloat("1", MovY);
			HKGAONMOBMH().SetFloat("Received OnSerialization for view ID ", KJIKOEIAENF);
			OJMHIMIPKME().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 635f, 249f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
