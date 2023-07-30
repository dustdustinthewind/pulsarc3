// CrosshairController
using UnityEngine;

public class CrosshairController : EnvironmentController
{
	public Color color = new Color(0.247f, 0.247f, 0.247f, 0.247f);

	public float colorLerp = 10f;

	public float emission;

	private Renderer[] BCMOCEGAAJI;

	public override void FBMDHDBELEK()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 0; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("/", Color.Lerp(renderer.material.GetColor(",viewkeys"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("\"", Color.Lerp(renderer.material.GetColor("_Value6"), color * (emission + 1431f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1581f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void LBPCODPOJAH()
	{
		base.BGFJOEPFOPM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 0; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("CameraFilterPack/FX_EarthQuake", Color.Lerp(renderer.material.GetColor("menu.hardcoreinfo"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_Near", Color.Lerp(renderer.material.GetColor("_Value"), color * (emission + 15f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1832f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void ANPICMEIMHH(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void JGKICMKMOKO()
	{
		base.Reset();
		color = new Color(1058f, 1110f, 662f, 1954f);
		color.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("LivesSlider", 747f);
		colorLerp = 426f;
		emission = 590f;
	}

	public override void DGGPNPLKCOE()
	{
		base.Reset();
		color = new Color(565f, 380f, 1338f, 73f);
		color.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("ComboText", 852f);
		colorLerp = 1009f;
		emission = 541f;
	}

	public override void EEBGCGFNELO()
	{
		base.Reset();
		color = new Color(1528f, 645f, 950f, 1550f);
		color.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_Value", 1710f);
		colorLerp = 1559f;
		emission = 909f;
	}

	public override void IBFJAOINHMK()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("_FixDistance", Color.Lerp(renderer.material.GetColor("_RandomTexture"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_Value2", Color.Lerp(renderer.material.GetColor(" ownership transfered to: "), color * (emission + 1027f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 236f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void DBCGALPFIMJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void KEGNPKFMPDG()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void ONMGIPAILOH()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("null", Color.Lerp(renderer.material.GetColor("\nCreated by Oxy949"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_Value5", Color.Lerp(renderer.material.GetColor("#rt"), color * (emission + 1610f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 894f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void FDKDBAOGBGI(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void BBBNLHALLBN()
	{
		base.OGAMGLEAOAF();
		color = new Color(588f, 142f, 1440f, 1849f);
		color.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("No Name", 237f);
		colorLerp = 1237f;
		emission = 527f;
	}

	public override void KACPCCMPAHA()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void FEAPMDENLBN()
	{
		base.Reset();
		color = new Color(1986f, 1954f, 637f, 894f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat(",", 600f);
		colorLerp = 188f;
		emission = 1017f;
	}

	public override void Awake()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void GOFKPNOIKKL(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("RecordButton", 1436f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void FNGEDBCPAOA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("Drop_Floor_Fluid", 351f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void IHLPMMHJEEH(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void KNNOEGLLDAN()
	{
		base.Reset();
		color = new Color(508f, 872f, 385f, 106f);
		color.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("Done! You are a contributor until: ", 1590f);
		colorLerp = 13f;
		emission = 1560f;
	}

	public void BBJJHMONBEO(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void AGMJDGHLBMN()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("visible", Color.Lerp(renderer.material.GetColor(" TimeOfRespawn: "), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("settings_bindings_controller_type", Color.Lerp(renderer.material.GetColor("_Blend"), color * (emission + 1723f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1119f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void FPKJJBAENGF()
	{
		base.OGAMGLEAOAF();
		color = new Color(1694f, 460f, 1416f, 447f);
		color.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_Value4", 378f);
		colorLerp = 1964f;
		emission = 859f;
	}

	public override void HPNNCNNFMGK()
	{
		base.AEIJFLJEABG();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("88f00bdf0ad61b16b803971ebe071962", Color.Lerp(renderer.material.GetColor("offsets"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("BloomShaderValueSlider", Color.Lerp(renderer.material.GetColor("_ScreenResolution"), color * (emission + 1462f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1025f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void MABNCCNOENN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("settings_bindings_controller_type", 1259f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void DGCGGKMNPLD()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("float,10", Color.Lerp(renderer.material.GetColor("HightScoreMaxPointsText"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_ScreenResolution", Color.Lerp(renderer.material.GetColor("Object ID. Case-Sensitive"), color * (emission + 543f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1298f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void JLMOKDABBLP(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void CGBHOELMAOC()
	{
		base.BGFJOEPFOPM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor(".lastCheckpoint.perfectHits", Color.Lerp(renderer.material.GetColor("_TimeX"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_CurveParams", Color.Lerp(renderer.material.GetColor("Set sun beat detection sensitivity"), color * (emission + 382f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1782f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void PEMPABLNJHL()
	{
		base.POHMFMNEPKK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void HAHPFDEBCCI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("Vertical", 592f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void IICACFLHBCP()
	{
		base.POHMFMNEPKK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void JNBMKLFJCEM()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void HBFLDGHLMBJ()
	{
		base.OGAMGLEAOAF();
		color = new Color(739f, 1838f, 57f, 959f);
		color.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("note.1", 1696f);
		colorLerp = 122f;
		emission = 965f;
	}

	public override void EIFCCFBJKOO()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void GCMLEEHGBPA()
	{
		base.OGAMGLEAOAF();
		color = new Color(467f, 937f, 938f, 1263f);
		color.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_EmissionColor", 19f);
		colorLerp = 1584f;
		emission = 1432f;
	}

	public override void NELFFHHCADM()
	{
		base.Reset();
		color = new Color(1441f, 98f, 1485f, 387f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("AmbientOcclusion", 1473f);
		colorLerp = 617f;
		emission = 454f;
	}

	public void NPPLIGLGDBJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("SetCrosshairEmission", 1858f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void CCDNJPNLGBN()
	{
		base.BODPLDJLFCF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void MFAMCFBKNCB(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_TimeX", 457f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void HOCOJMHOCPA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_ScreenResolution", 1608f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void PHHOMLJECOJ()
	{
		base.BODPLDJLFCF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void CJNAIOCONCO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("subscribeall", 323f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void GHMCBHOHGIG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_ColorLevel", 1290f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void HMBLLAECOIL()
	{
		base.Reset();
		color = new Color(907f, 1147f, 732f, 553f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("Crosshair2", 1129f);
		colorLerp = 508f;
		emission = 75f;
	}

	public void IEOLBPBNABJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_SphereSize", 689f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void HFCJHNPGKEG()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void LEDOFAPCIEJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void NDAJBJFJGCF()
	{
		base.LEAHIBJDMBI();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("PlaySound", Color.Lerp(renderer.material.GetColor("LevelInfoInputField"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("skin.no_hit", Color.Lerp(renderer.material.GetColor("LostLive"), color * (emission + 502f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1884f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void FABMDEHEDNO()
	{
		base.AEIJFLJEABG();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 0; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("StartTime already set: ", Color.Lerp(renderer.material.GetColor("settings_bindings_sec_"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("menu.enableselectormusic", Color.Lerp(renderer.material.GetColor("Committing changes..."), color * (emission + 22f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 316f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void LGNKOPCPPEM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("_MainTex2", 1887f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void GGALLPMKOJI()
	{
		base.OGAMGLEAOAF();
		color = new Color(93f, 1731f, 1042f, 1363f);
		color.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("YES", 1036f);
		colorLerp = 423f;
		emission = 1650f;
	}

	public override void AIJGAJIOJDJ()
	{
		base.BGFJOEPFOPM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("_Green_B", Color.Lerp(renderer.material.GetColor("OK"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("Populate Mesh Data", Color.Lerp(renderer.material.GetColor("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception"), color * (emission + 1126f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 215f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void HENCAKLCCNO(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void CEKLAECJCKG()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void JBIFKBNPHJE()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void MGHHDLLGOCJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("Toggle {0} is not part of ToggleGroup {1}", 1930f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void DAHIMKKFNPH()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void OPCLBGHAPMG()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("original.tutorial", Color.Lerp(renderer.material.GetColor("_Bullet_4"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Color.Lerp(renderer.material.GetColor(" not exist"), color * (emission + 697f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 369f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void GJEIGCHBKJG(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void BGJFENIEABH(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("#failed: ", 1930f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void LIFEOKGNBFP()
	{
		base.Reset();
		color = new Color(782f, 370f, 112f, 674f);
		color.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("&", 90f);
		colorLerp = 1554f;
		emission = 1879f;
	}

	public void FLDKEJMNKDA(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void JCDNBEOMBKG(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void LCJHDLKJEOM()
	{
		base.LEAHIBJDMBI();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("settings.gamemessagesduration", Color.Lerp(renderer.material.GetColor("_Value3"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("ConfigVersionSlider", Color.Lerp(renderer.material.GetColor("[ResourcesManager] Load image error: "), color * (emission + 1629f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1044f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void FBLCOFJCLIN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("_Value", 800f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void EHMMNELHAPJ()
	{
		base.OGAMGLEAOAF();
		color = new Color(465f, 1979f, 933f, 178f);
		color.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("PunRespawn", 749f);
		colorLerp = 253f;
		emission = 1642f;
	}

	public void CNLLLMBKLOH(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("_ExtraLight", 1827f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void MPFAHHOEMLL(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void EPJJDKJEDMM()
	{
		base.LEAHIBJDMBI();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("_MainTex", Color.Lerp(renderer.material.GetColor(","), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("editorVolume", Color.Lerp(renderer.material.GetColor("0.00/0.00"), color * (emission + 1939f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1399f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void AKDFBHFFKFM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("AskForPickupItemSpawnTimes", 494f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void OIBMHPIFAKK()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("_Value3", Color.Lerp(renderer.material.GetColor(">"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("Set particles audio input", Color.Lerp(renderer.material.GetColor(".lastCheckpoint.comboScore"), color * (emission + 523f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1117f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void HIFJLPPFCEC(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void BDHJEDNAKNO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("SSAARenderTargetCamera", 309f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void GBEAKNALDOE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void HCIPECAOGIA()
	{
		base.BGFJOEPFOPM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 0; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("_QualitySettings", Color.Lerp(renderer.material.GetColor("LevelEditor/icons"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("QuickSave", Color.Lerp(renderer.material.GetColor("Observed type is not serializable: "), color * (emission + 1732f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 934f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void CEACMFGNDEB()
	{
		base.OGAMGLEAOAF();
		color = new Color(1987f, 254f, 971f, 1037f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("Joystick1Button11", 1038f);
		colorLerp = 1041f;
		emission = 494f;
	}

	public override void ELBLLBJBFCL()
	{
		base.Reset();
		color = new Color(316f, 1976f, 1280f, 928f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("Item invalid. No idea why.", 1630f);
		colorLerp = 1911f;
		emission = 748f;
	}

	public override void GEGFJJBCHPE()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void JOBBGDGHJMB()
	{
		base.BODPLDJLFCF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void MCDIPGCGNIM(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void KAMMKPFNJJF()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void HHDEDGGGOGJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void JNIPABEGJND()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void CJNFBCCHNLG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO(".", 531f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void FFDBBLDKCNJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("HitVariationSlider", 960f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void Update()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("_Color", Color.Lerp(renderer.material.GetColor("_Color"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_EmissionColor", Color.Lerp(renderer.material.GetColor("_EmissionColor"), color * (emission + 1f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 0f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void JDCEGKOFBKN()
	{
		base.OGAMGLEAOAF();
		color = new Color(1186f, 44f, 1256f, 486f);
		color.a = Singleton<SaveSystem>.Instance.DPAGLGGNECO("maps.", 1036f);
		colorLerp = 1959f;
		emission = 1727f;
	}

	public void MHNOBMMDIIN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("event", 1179f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void MHLOFLAEADE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void FIABIKEIEKH()
	{
		base.POHMFMNEPKK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void Reset()
	{
		base.Reset();
		color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f);
		colorLerp = 10f;
		emission = 0f;
	}

	public void CBFDAKKKCMK(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void MIFIEGOGKDA()
	{
		base.OGAMGLEAOAF();
		color = new Color(1316f, 680f, 677f, 264f);
		color.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("Save the map before exiting?", 1283f);
		colorLerp = 1841f;
		emission = 168f;
	}

	public override void MANOCIJICLG()
	{
		base.Reset();
		color = new Color(1868f, 1717f, 685f, 114f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("_AreaTex", 327f);
		colorLerp = 767f;
		emission = 1913f;
	}

	public override void PKHPNHBEKHA()
	{
		base.BGFJOEPFOPM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("X", Color.Lerp(renderer.material.GetColor(".b"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_FixDistance", Color.Lerp(renderer.material.GetColor("CameraFilterPack/Color_Contrast"), color * (emission + 355f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1281f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void NLFCFJJDPMB(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void OPFDGBDADMA()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void KGMCGGIEPDE()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void OGAMGLEAOAF()
	{
		base.OGAMGLEAOAF();
		color = new Color(1401f, 1244f, 877f, 1127f);
		color.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("Line", 1013f);
		colorLerp = 580f;
		emission = 156f;
	}

	public override void GKBKKJAEKBJ()
	{
		base.OGAMGLEAOAF();
		color = new Color(869f, 1129f, 311f, 766f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("CameraFilterPack/Atmosphere_Fog", 1825f);
		colorLerp = 214f;
		emission = 114f;
	}

	public override void POHMFMNEPKK()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void FJHFOBHJEHL()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("\0\0", Color.Lerp(renderer.material.GetColor(" takes from: "), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("id", Color.Lerp(renderer.material.GetColor("a month ago"), color * (emission + 1864f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1083f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void BGFCMMDKCOI()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void NNDAJNEINKI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("player.greenlifering", 383f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void KFACDBHDAOD()
	{
		base.LEAHIBJDMBI();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 0; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("_Value9", Color.Lerp(renderer.material.GetColor("settings.arcsdestroydelay"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_Distortion", Color.Lerp(renderer.material.GetColor("Created by "), color * (emission + 577f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1070f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void MGGNFEPGIJI()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void OJACCGOHBGH()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void JOACBIEHHCE()
	{
		base.BGFJOEPFOPM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("CameraFilterPack/Blend2Camera_SplitScreen3D", Color.Lerp(renderer.material.GetColor("_Overlay"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_ScreenResolution", Color.Lerp(renderer.material.GetColor("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys"), color * (emission + 1187f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1538f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void PPGKBEJLBFJ()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void POJFHDFJOPE()
	{
		base.AEIJFLJEABG();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("_Value", Color.Lerp(renderer.material.GetColor("hidden"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("/?player=", Color.Lerp(renderer.material.GetColor("PointsScoreText"), color * (emission + 207f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 62f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void MCIEAOAMOIG()
	{
		base.POHMFMNEPKK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void DNENFLNCIJP()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("2;13;14;15;16", Color.Lerp(renderer.material.GetColor("#{0:00} '{1}'{2} {3}"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", Color.Lerp(renderer.material.GetColor("GenerationMenu"), color * (emission + 1114f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 114f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void LDGJGONCEND()
	{
		base.Reset();
		color = new Color(1952f, 1560f, 1531f, 1197f);
		color.a = Singleton<SaveSystem>.Instance.HCNELAJLBPC("_TimeX", 1837f);
		colorLerp = 37f;
		emission = 37f;
	}

	public override void LECPHJOIGKN()
	{
		base.OGAMGLEAOAF();
		color = new Color(610f, 1970f, 1952f, 4f);
		color.a = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_ScreenResolution", 1452f);
		colorLerp = 635f;
		emission = 1632f;
	}

	public override void IIFCIDDJHPM()
	{
		base.AEIJFLJEABG();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("CameraFilterPack/3D_Anomaly", Color.Lerp(renderer.material.GetColor("closed"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_Value3", Color.Lerp(renderer.material.GetColor("_Value2"), color * (emission + 172f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1803f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}
}
