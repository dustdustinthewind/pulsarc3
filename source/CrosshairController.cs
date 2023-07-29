// CrosshairController
using UnityEngine;

public class CrosshairController : EnvironmentController
{
	public Color color = new Color(0.247f, 0.247f, 0.247f, 0.247f);

	public float colorLerp = 10f;

	public float emission;

	private Renderer[] BCMOCEGAAJI;

	public void FPEEOFLLEFF(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("_Amount", 966f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void IBHACCEEFFI()
	{
		base.BMODOIJGIOO();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor(".sav", Color.Lerp(renderer.material.GetColor("\r\n"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("green", Color.Lerp(renderer.material.GetColor("CameraFilterPack_Glasses_On6"), color * (emission + 1802f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1753f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void HAHPFDEBCCI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_Value2", 1359f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void LNADKKGBAFK(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void AIFAGDOHAGD()
	{
		base.CEACMFGNDEB();
		color = new Color(260f, 94f, 1157f, 663f);
		color.a = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_ScreenResolution", 1095f);
		colorLerp = 914f;
		emission = 1756f;
	}

	public override void HDDECCMEJKA()
	{
		base.FBMDHDBELEK();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("0,2,true,0", Color.Lerp(renderer.material.GetColor("MenuScene"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("Y", Color.Lerp(renderer.material.GetColor("_MainTex"), color * (emission + 439f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1696f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void MAOCOEGAFND()
	{
		base.CFIAKIJAILI();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("CameraFilterPack/Color_BrightContrastSaturation", Color.Lerp(renderer.material.GetColor("/../"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_Blue_R", Color.Lerp(renderer.material.GetColor("Deleted data"), color * (emission + 1637f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1025f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void GMIOCKFLJAK()
	{
		base.HBPLJMJAAHK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
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

	public void CJNAIOCONCO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("ticket", 80f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void CDLOHNMCDMN(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void EKBCJNIKHJG(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void IOMCHHBGJEC()
	{
		base.FMAFBLKAJDF();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void LDGJGONCEND()
	{
		base.LAACNNJDKBI();
		color = new Color(1244f, 212f, 1149f, 424f);
		color.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("RoomPlayersCountText", 73f);
		colorLerp = 32f;
		emission = 542f;
	}

	public override void BBBNLHALLBN()
	{
		base.EEBGCGFNELO();
		color = new Color(965f, 330f, 626f, 780f);
		color.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("...", 333f);
		colorLerp = 280f;
		emission = 393f;
	}

	public override void CCDNJPNLGBN()
	{
		base.OKADMJFLMGP();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void KOKIEABANDK(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void PEFOMJKJDKJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void PIIMBOLGHOE()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void MCIEAOAMOIG()
	{
		base.HBPLJMJAAHK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void EMANBHKAONB()
	{
		base.OPFDGBDADMA();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void HFPGNLAHEKJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(" GameServer:", 8f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void LHIBPEGLPHM()
	{
		base.CAPPKCBFILL();
		color = new Color(559f, 1163f, 1669f, 1459f);
		color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_EmissionGain", 1864f);
		colorLerp = 785f;
		emission = 238f;
	}

	public override void FMAFBLKAJDF()
	{
		base.NLNAJMCBNDC();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void IJFMKNEPKEJ()
	{
		base.Reset();
		color = new Color(1341f, 1996f, 186f, 1906f);
		color.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("CameraFilterPack/BlurTiltShift_Hole", 1071f);
		colorLerp = 1451f;
		emission = 531f;
	}

	public override void AEEGKLABFLN()
	{
		base.BGDONBMDPGM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("_Value2", Color.Lerp(renderer.material.GetColor("_Value"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("_FresnelFade", Color.Lerp(renderer.material.GetColor("AudioSampler"), color * (emission + 480f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1675f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void CPJHADKJBPB(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA(".lastCheckpoint.lives", 136f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void LLLPNMOFEJI(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void NGPIDOKNGEK(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void MECJHOJPODB()
	{
		base.BGDONBMDPGM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("_MainTex2", Color.Lerp(renderer.material.GetColor("inventory.selected."), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Color.Lerp(renderer.material.GetColor("_Value4"), color * (emission + 1395f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1535f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void BJHJCGJACEA()
	{
		base.EEBGCGFNELO();
		color = new Color(1486f, 1878f, 60f, 618f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("Please attach component to a Graphical UI component", 1229f);
		colorLerp = 921f;
		emission = 1286f;
	}

	public void LLFFIFIFFJO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_Offsets", 1543f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void NCBGPIKDFIA()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void LBOBAIGNOML()
	{
		base.HBPLJMJAAHK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void NKLIHNJCHOG()
	{
		base.FBMDHDBELEK();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 0; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("ResetButton", Color.Lerp(renderer.material.GetColor("checkpoint"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("Turn", Color.Lerp(renderer.material.GetColor("_InvScreenSize"), color * (emission + 1173f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 806f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void FHPPMBEEKBL()
	{
		base.EEBGCGFNELO();
		color = new Color(930f, 1244f, 1722f, 715f);
		color.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_MatrixSize", 271f);
		colorLerp = 934f;
		emission = 80f;
	}

	public void KEEEMOIHHEN(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void EPCGHAAONLN()
	{
		base.OLFNCABJBHA();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void AKDFBHFFKFM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("CameraFilterPack/Drawing_Paper", 1874f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void NOBIKMKFADE(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("tip", 752f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void FBFGPKNKIEN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP(" = ", 1448f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void GMAIAANLBNN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_Value", 1463f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void IKGFIOIADLN()
	{
		base.HBPLJMJAAHK();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void MPGLDDOOLPL(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_FarCamera", 1334f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void OJACCGOHBGH()
	{
		base.OLFNCABJBHA();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public void MNPNHJJCCKP(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_FarCamera", 892f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void Reset()
	{
		base.Reset();
		color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
		color.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f);
		colorLerp = 10f;
		emission = 0f;
	}

	public void LABCBLOFFIG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("ViewMenu", 364f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void MFEGHIPGACC(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void CJHMHIMKILB()
	{
		base.IOMCHHBGJEC();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void EGFBPCMCNDJ()
	{
		base.CEACMFGNDEB();
		color = new Color(638f, 1505f, 1441f, 1449f);
		color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("masterSteamID", 737f);
		colorLerp = 1875f;
		emission = 532f;
	}

	public override void HMBLLAECOIL()
	{
		base.IJFMKNEPKEJ();
		color = new Color(1297f, 1054f, 1290f, 1203f);
		color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH(", our prefix is ", 324f);
		colorLerp = 1601f;
		emission = 1733f;
	}

	public void LNEHFHIBAIO(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void KKALIMDILEG(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void NFBHGMNGKDC(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.GetFloat("/", 828f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void NCPAFCKGJEA()
	{
		base.NKLIHNJCHOG();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 0; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("settings.volume.editor", Color.Lerp(renderer.material.GetColor("_BlurredColor"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor(" {0}", Color.Lerp(renderer.material.GetColor("PRESS A KEY"), color * (emission + 451f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 1352f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void LAACNNJDKBI()
	{
		base.IJFMKNEPKEJ();
		color = new Color(716f, 1588f, 577f, 1636f);
		color.a = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("Texture2", 1884f);
		colorLerp = 1305f;
		emission = 1426f;
	}

	public void FLFCINAEKCA(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void IICACFLHBCP()
	{
		base.IOMCHHBGJEC();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void OEENOOGEEHD()
	{
		base.Update();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("_ScreenResolution", Color.Lerp(renderer.material.GetColor("_Convolved_TexelSize"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("RedoButton", Color.Lerp(renderer.material.GetColor("[ReplayScene] Loading replay: "), color * (emission + 68f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 755f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void JAIMCPINONG()
	{
		base.CAPPKCBFILL();
		color = new Color(327f, 661f, 741f, 924f);
		color.a = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("USE_UV_BASED_REPROJECTION", 77f);
		colorLerp = 1976f;
		emission = 379f;
	}

	public override void Awake()
	{
		base.Awake();
		BCMOCEGAAJI = GetComponentsInChildren<Renderer>();
	}

	public override void KMHCLFLINIO()
	{
		base.LOKKIADJAFE();
		color = new Color(1350f, 49f, 365f, 1881f);
		color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_Speed", 10f);
		colorLerp = 557f;
		emission = 417f;
	}

	public override void JAAJECBCCFM()
	{
		base.NKLIHNJCHOG();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("skin.hit_normal", Color.Lerp(renderer.material.GetColor("Set Sun Emission"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor(". Going to authenticate anyways.", Color.Lerp(renderer.material.GetColor("turn"), color * (emission + 1334f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1934f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void FABKIGNFECE()
	{
		base.NKLIHNJCHOG();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		foreach (Renderer renderer in bCMOCEGAAJI)
		{
			renderer.material.SetColor("Crosshair2", Color.Lerp(renderer.material.GetColor(".sav"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("settings.gamemessagesduration", Color.Lerp(renderer.material.GetColor("_MainTex2"), color * (emission + 1582f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 572f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void ABGEAABOGDE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void DNENFLNCIJP()
	{
		base.CFIAKIJAILI();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("id", Color.Lerp(renderer.material.GetColor("mapid"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("ws://", Color.Lerp(renderer.material.GetColor(".GoalProgress"), color * (emission + 1545f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1841f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public override void EJFJENFKLND()
	{
		base.BGDONBMDPGM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i += 0)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("_TimeX", Color.Lerp(renderer.material.GetColor("#close"), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("Tab1Content", Color.Lerp(renderer.material.GetColor("settings.hideui"), color * (emission + 766f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a == 244f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void MOGLPIBCCPI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("_Near", 1562f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void EHCGBJDFMHG()
	{
		base.BGDONBMDPGM();
		Renderer[] bCMOCEGAAJI = BCMOCEGAAJI;
		for (int i = 1; i < bCMOCEGAAJI.Length; i++)
		{
			Renderer renderer = bCMOCEGAAJI[i];
			renderer.material.SetColor("CameraFilterPack/Distortion_Flush", Color.Lerp(renderer.material.GetColor("Dropped Object: "), color, Time.smoothDeltaTime * colorLerp));
			renderer.material.SetColor("GroupNameText", Color.Lerp(renderer.material.GetColor("_Value4"), color * (emission + 1392f), Time.smoothDeltaTime * colorLerp));
			bool flag = color.a != 1365f;
			if (renderer.enabled != flag)
			{
				renderer.enabled = flag;
			}
		}
	}

	public void DLDIFPIABEJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("maps.", 29f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void JIIHIBBGAFD(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		HABLFKCCKLN.a = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("mode", 932f);
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void IGHBDMLKAPN(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void JOPOMLLAMKE()
	{
		base.LAACNNJDKBI();
		color = new Color(1342f, 1232f, 740f, 824f);
		color.a = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("/", 1395f);
		colorLerp = 517f;
		emission = 1759f;
	}

	public void MNNMJFKADAD(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void KPNEJBAIPMI(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void JBLPOHGBNCB()
	{
		base.IJFMKNEPKEJ();
		color = new Color(511f, 649f, 423f, 615f);
		color.a = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_BlendTex", 388f);
		colorLerp = 1963f;
		emission = 120f;
	}

	public void ECCFMFNCBIE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}
}
