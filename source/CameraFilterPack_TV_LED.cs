// CameraFilterPack_TV_LED
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/LED")]
public class CameraFilterPack_TV_LED : MonoBehaviour
{
	public Shader SCShader;

	private Vector4 GOIJPFAHKPE;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade;

	[Range(1f, 10f)]
	private float GAMMLIDAPPF = 1f;

	[Range(1f, 15f)]
	public int Size = 5;

	private Material BJFKDHHMLJH;

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

	private void HCDBNAKGDJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 847f)
			{
				HBJJOCHGOPH = 1211f;
			}
			LMLENGFLEBD().SetFloat("Loaded skin audio", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("_TimeX", Size);
			HJGEHJDMCGI().SetFloat(":", Fade);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/Edge_Neon", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("[MapsSystem] Unloading maps resources...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1879f, 284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1595f)
			{
				HBJJOCHGOPH = 117f;
			}
			KEMAALEODNH().SetFloat("[GameScene] Submiting rank", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("settings.hitvariation", Size);
			ECCPAOBFDKP().SetFloat("OnPickedUp", Fade);
			DABHAJNHOAL().SetFloat("Scene", GAMMLIDAPPF);
			DEFBJOCJJKF().SetVector("???", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 463f, 1232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1028f)
			{
				HBJJOCHGOPH = 579f;
			}
			KBOPGONOCNP().SetFloat("MenuPlayButton", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("Object ID. Case-Sensitive", Size);
			DOMEEFLPEPJ().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", Fade);
			INOBFNCKFGK().SetFloat("_Value4", GAMMLIDAPPF);
			PLBEJJIHFPB().SetVector("#scoresubmitionfailed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1386f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKKOIKKIDEG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 30f)
			{
				HBJJOCHGOPH = 1823f;
			}
			KEMAALEODNH().SetFloat("Indie", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("Run a command for data system", Size);
			MLMKCOINOOH().SetFloat("DPADVER", Fade);
			NBMPPNFKFLB().SetFloat("_TimeX", GAMMLIDAPPF);
			OLHDPICFBOF().SetVector("_BgColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 191f, 1051f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDJEJBBDILE()
	{
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 451f)
			{
				HBJJOCHGOPH = 1341f;
			}
			KBOPGONOCNP().SetFloat("[MapEditor] Openning ", HBJJOCHGOPH);
			HBLDMJCOAHA().SetFloat("#", Size);
			KEMAALEODNH().SetFloat("OK", Fade);
			MLMKCOINOOH().SetFloat("0,7,true,0", GAMMLIDAPPF);
			INOBFNCKFGK().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 498f, 1815f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1568f)
			{
				HBJJOCHGOPH = 1528f;
			}
			EBJKJPAIAAM().SetFloat("_Value2", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("0,1,false", Size);
			LPCHMEKDCHI().SetFloat("/icon", Fade);
			EBJKJPAIAAM().SetFloat("_Value2", GAMMLIDAPPF);
			INOBFNCKFGK().SetVector("CameraFilterPack/Blend2Camera_Exclusion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1655f, 558f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JOACBIEHHCE()
	{
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1268f)
			{
				HBJJOCHGOPH = 946f;
			}
			INOBFNCKFGK().SetFloat(" cannot be used as a 3D LUT.", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", Size);
			PHGCJOPFDOG().SetFloat("player.bluelifering", Fade);
			ADBKPGFMNKO().SetFloat("Set Sun Input", GAMMLIDAPPF);
			LMLENGFLEBD().SetVector("PublishButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 970f, 841f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PEIMCBBHLBJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("_MatrixSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 111f)
			{
				HBJJOCHGOPH = 658f;
			}
			KEMAALEODNH().SetFloat("Edited unlock conditions", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("PunSupportLogger", Size);
			EBJKJPAIAAM().SetFloat("_Near", Fade);
			EBJKJPAIAAM().SetFloat("LoadMapCanvas", GAMMLIDAPPF);
			DOMEEFLPEPJ().SetVector(" Owner called.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 157f, 1086f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGOPJMGNHGO()
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
			if (HBJJOCHGOPH > 1593f)
			{
				HBJJOCHGOPH = 83f;
			}
			IGKFMCPDNOI().SetFloat("PickupItemInit", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_EmissionColor", Size);
			NBMPPNFKFLB().SetFloat("ReconnectAndRejoin() with AuthValues == null is not correct!", Fade);
			INOBFNCKFGK().SetFloat("powerup.1", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("float,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1463f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 916f)
			{
				HBJJOCHGOPH = 231f;
			}
			HBLDMJCOAHA().SetFloat("_History2LumaTex", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("red", Size);
			PEIMCBBHLBJ().SetFloat("PunSupportLogger", Fade);
			BLMPMOIDGMG().SetFloat("win", GAMMLIDAPPF);
			PHGCJOPFDOG().SetVector("#", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 80f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DPIPGGDNGHN()
	{
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1725f)
			{
				HBJJOCHGOPH = 1427f;
			}
			EBJKJPAIAAM().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("float,2", Size);
			ECCPAOBFDKP().SetFloat("#,0.00", Fade);
			GKILCDHJFEG().SetFloat("settings_bindings_sec_", GAMMLIDAPPF);
			INOBFNCKFGK().SetVector("win", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 967f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
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
			if (HBJJOCHGOPH > 1821f)
			{
				HBJJOCHGOPH = 829f;
			}
			HKGAONMOBMH().SetFloat("z", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Size);
			PEIMCBBHLBJ().SetFloat("LevelNameInputField", Fade);
			GCDFNHMJMIP().SetFloat("_SizeY", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("CheckpointsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 793f, 164f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMNOHLNANIP()
	{
	}

	private void HMNLHMLILKD()
	{
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void NJBLKNHAHJD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1569f)
			{
				HBJJOCHGOPH = 408f;
			}
			KBOPGONOCNP().SetFloat("]. Please verify you have this gameobject in a Resources folder.", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Spawn new environment object (sun, satellite etc) and sets its id", Size);
			HJGEHJDMCGI().SetFloat("_Value", Fade);
			PEIMCBBHLBJ().SetFloat("#,0.00", GAMMLIDAPPF);
			GCDFNHMJMIP().SetVector("&", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 189f, 1965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
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
			NBPKMLMCHFN.SetFloat("_Size", Size);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("_Distortion", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1918f)
			{
				HBJJOCHGOPH = 792f;
			}
			BLMPMOIDGMG().SetFloat("cancel", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_DotSize", Size);
			DOMEEFLPEPJ().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", Fade);
			DABHAJNHOAL().SetFloat("VIGNETTE_FILMIC", GAMMLIDAPPF);
			LMLENGFLEBD().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1271f, 1335f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("Set particles audio input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 782f)
			{
				HBJJOCHGOPH = 1005f;
			}
			GCDFNHMJMIP().SetFloat("finished", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Size);
			DABHAJNHOAL().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", Fade);
			PEIMCBBHLBJ().SetFloat("_Speed", GAMMLIDAPPF);
			DABHAJNHOAL().SetVector("StopSounds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 515f, 1306f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 569f)
			{
				HBJJOCHGOPH = 1710f;
			}
			DOMEEFLPEPJ().SetFloat("CameraFilterPack/FX_Grid", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("[LevelEditorScene] Print Audio Wave: Start", Size);
			OLHDPICFBOF().SetFloat("ChangeSelectedLevel", Fade);
			DABHAJNHOAL().SetFloat("_Value3", GAMMLIDAPPF);
			ADBKPGFMNKO().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1220f, 524f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1334f)
			{
				HBJJOCHGOPH = 205f;
			}
			HKGAONMOBMH().SetFloat("SelectorMapsCountSlider", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat(".lastCheckpoint.checkpointsUsed", Size);
			KBOPGONOCNP().SetFloat("outputitemdefid", Fade);
			GCDFNHMJMIP().SetFloat("B:", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("CameraFilterPack_Broken_Screen1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1385f, 1824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("_Exponent");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void BDBFMPGAKCE()
	{
	}

	private void ANDELGODEOC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void FOLDLDLFFLM()
	{
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void DPGEHNHFHJE()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 70f)
			{
				HBJJOCHGOPH = 861f;
			}
			PEIMCBBHLBJ().SetFloat("Player Disconnected", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("Deleted event", Size);
			NBPKMLMCHFN.SetFloat("_CenterY", Fade);
			PHGCJOPFDOG().SetFloat("offsets", GAMMLIDAPPF);
			HKGAONMOBMH().SetVector("settings.arcshitsoundtimedelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 535f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DABHAJNHOAL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 886f)
			{
				HBJJOCHGOPH = 1704f;
			}
			IGKFMCPDNOI().SetFloat("_Amount", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("_ScreenResolution", Size);
			EBJKJPAIAAM().SetFloat("Source: ", Fade);
			KBOPGONOCNP().SetFloat("mapselector.filter.favoriteonly", GAMMLIDAPPF);
			IGKFMCPDNOI().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 515f, 1275f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("[#clicktogetreward]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FAKGFMFAPDG()
	{
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EBJKJPAIAAM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return BJFKDHHMLJH;
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 668f)
			{
				HBJJOCHGOPH = 707f;
			}
			IGKFMCPDNOI().SetFloat("settings.arcsnohitsoundtimedelay", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("settings.volume.editor", Size);
			PHGCJOPFDOG().SetFloat("MapperNameText", Fade);
			EBJKJPAIAAM().SetFloat("_Offsets", GAMMLIDAPPF);
			HKGAONMOBMH().SetVector("#.##", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1612f, 239f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("SelectorMapsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HJGEHJDMCGI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1523f)
			{
				HBJJOCHGOPH = 1340f;
			}
			PHGCJOPFDOG().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("[ERROR KEY {0}]", Size);
			PLBEJJIHFPB().SetFloat("_Value2", Fade);
			HJGEHJDMCGI().SetFloat("_SSAO", GAMMLIDAPPF);
			PLBEJJIHFPB().SetVector("IconImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1499f, 1240f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1381f)
			{
				HBJJOCHGOPH = 331f;
			}
			ADBKPGFMNKO().SetFloat("_Value4", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("Data/Skins/", Size);
			BLMPMOIDGMG().SetFloat(" ", Fade);
			HNFFHCLNBDN().SetFloat("wss://", GAMMLIDAPPF);
			ECCPAOBFDKP().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 942f, 442f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 332f)
			{
				HBJJOCHGOPH = 669f;
			}
			DOMEEFLPEPJ().SetFloat("_DepthLevel", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_TimeX", Size);
			ADBKPGFMNKO().SetFloat("Noise shaders are not set up! Disabling noise effect.", Fade);
			DOMEEFLPEPJ().SetFloat("turn: {0:0}", GAMMLIDAPPF);
			GKILCDHJFEG().SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1926f, 1608f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("GlassAberration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1093f)
			{
				HBJJOCHGOPH = 953f;
			}
			OLHDPICFBOF().SetFloat("menu.playedpage", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Set Satellite Trail Length", Size);
			HNFFHCLNBDN().SetFloat("delete", Fade);
			MLMKCOINOOH().SetFloat("_MainTex2", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector(" Kb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1599f, 189f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BNLENEDAHHL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOHOFNKJDEB()
	{
		SCShader = Shader.Find("_Rand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NJHJHBOJKIC()
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
			if (HBJJOCHGOPH > 1292f)
			{
				HBJJOCHGOPH = 1466f;
			}
			DEFBJOCJJKF().SetFloat("speed", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("_SizeY", Size);
			DOMEEFLPEPJ().SetFloat("SetSunSensitivity", Fade);
			ADBKPGFMNKO().SetFloat("No info", GAMMLIDAPPF);
			PEIMCBBHLBJ().SetVector("_Color_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 1194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("_SecondTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 612f)
			{
				HBJJOCHGOPH = 1243f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Gradients_Tech", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("Joined room ", Size);
			BLMPMOIDGMG().SetFloat("SetSunEmission", Fade);
			GKILCDHJFEG().SetFloat("_StretchWidth", GAMMLIDAPPF);
			PLBEJJIHFPB().SetVector(" Gb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 81f, 553f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("L2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void MEBPBNLBECA()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FIJHDKIPENG()
	{
		SCShader = Shader.Find("an hour ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 335f)
			{
				HBJJOCHGOPH = 465f;
			}
			NBPKMLMCHFN.SetFloat("help", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("_Distortion", Size);
			KBOPGONOCNP().SetFloat("note.2", Fade);
			GKILCDHJFEG().SetFloat("CameraFilterPack/3D_Computer", GAMMLIDAPPF);
			INOBFNCKFGK().SetVector("Depth textures aren't supported on this device ({0})", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 483f, 605f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("_Greenness");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void IBLGHLNNAHN()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_LED");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EDPDMBFLHLP()
	{
		SCShader = Shader.Find("GraphicsQualitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 149f)
			{
				HBJJOCHGOPH = 342f;
			}
			PHGCJOPFDOG().SetFloat("CameraFilterPack/Noise_TV_3", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("plogs", Size);
			HKGAONMOBMH().SetFloat("_History3Weight", Fade);
			NBMPPNFKFLB().SetFloat("_Value2", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("STICKLHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 236f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
			if (HBJJOCHGOPH > 1404f)
			{
				HBJJOCHGOPH = 245f;
			}
			PHGCJOPFDOG().SetFloat("_InternalLutTex", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("SpawnObj", Size);
			LNLKMDPHDCC().SetFloat("_Speed", Fade);
			EBJKJPAIAAM().SetFloat("[MenuScene] Error: ", GAMMLIDAPPF);
			LPCHMEKDCHI().SetVector("s", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1950f, 1212f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 199f)
			{
				HBJJOCHGOPH = 782f;
			}
			HNFFHCLNBDN().SetFloat("Items/", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("CameraFilterPack/Glasses_On", Size);
			HNFFHCLNBDN().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", Fade);
			HNFFHCLNBDN().SetFloat(" cannot be used as a 3D LUT.", GAMMLIDAPPF);
			DABHAJNHOAL().SetVector("CameraFilterPack/Glasses_On", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1401f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1513f)
			{
				HBJJOCHGOPH = 638f;
			}
			ECCPAOBFDKP().SetFloat("#news", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("Item invalid. No idea why.", Size);
			GCDFNHMJMIP().SetFloat("[ImageLoader] Loaded image from ", Fade);
			IGKFMCPDNOI().SetFloat("settings_bindings_controller_type", GAMMLIDAPPF);
			HBLDMJCOAHA().SetVector("_SunPosition", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 369f, 1830f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1782f)
			{
				HBJJOCHGOPH = 1090f;
			}
			PHGCJOPFDOG().SetFloat("Ok", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("settings.hitvariation", Size);
			GCDFNHMJMIP().SetFloat("BitsData", Fade);
			PDEAHJPOMEF().SetFloat("keys", GAMMLIDAPPF);
			PLBEJJIHFPB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1113f, 1663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IBKFIFHFMFF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MANDOGNJJBD()
	{
	}

	private void NMAOGOMAING()
	{
		SCShader = Shader.Find("Joystick1Button6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void BFGIMALGMAJ()
	{
	}

	private void KIEJKBNBHMD()
	{
	}

	private void LDDKCCMHMIC()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 144f)
			{
				HBJJOCHGOPH = 824f;
			}
			PEIMCBBHLBJ().SetFloat("Chat", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", Size);
			GKILCDHJFEG().SetFloat("/", Fade);
			DABHAJNHOAL().SetFloat("_DiffuseColor", GAMMLIDAPPF);
			EBJKJPAIAAM().SetVector("STICKLVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1080f, 546f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("-help");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFBPKPPECMC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("DontDestroy");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find(".lastCheckpoint.currentCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JOPBEKMPPJK()
	{
		SCShader = Shader.Find("MapEditorScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("open");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 843f)
			{
				HBJJOCHGOPH = 48f;
			}
			HJGEHJDMCGI().SetFloat(" not exist", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("DifficultyBG", Size);
			PLBEJJIHFPB().SetFloat(": ", Fade);
			GCDFNHMJMIP().SetFloat("Drop_With_Obj", GAMMLIDAPPF);
			HBLDMJCOAHA().SetVector("skin.hit_perfect", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 900f, 816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICGNMOFMLFA()
	{
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("Right Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void POIEGKJEHIP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void MKFFLJGJMLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 161f)
			{
				HBJJOCHGOPH = 1901f;
			}
			GCDFNHMJMIP().SetFloat("float,0", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("_Blue_C", Size);
			KEMAALEODNH().SetFloat("ReJoinRoom failed due to offline mode.", Fade);
			ADBKPGFMNKO().SetFloat("No problem found, so far", GAMMLIDAPPF);
			NBMPPNFKFLB().SetVector("_VignetteSettings", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1609f, 1868f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1141f)
			{
				HBJJOCHGOPH = 1571f;
			}
			DOMEEFLPEPJ().SetFloat("skin.", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("MainCamera", Size);
			LMLENGFLEBD().SetFloat("ChallengesButton", Fade);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", GAMMLIDAPPF);
			HNFFHCLNBDN().SetVector("s", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1744f, 731f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DABHAJNHOAL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HBLDMJCOAHA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1083f)
			{
				HBJJOCHGOPH = 95f;
			}
			IGKFMCPDNOI().SetFloat("_CurrentMipLevel", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Folk", Size);
			HBLDMJCOAHA().SetFloat("CameraFilterPack/FX_Dot_Circle", Fade);
			BLMPMOIDGMG().SetFloat("_Bullet_8", GAMMLIDAPPF);
			GCDFNHMJMIP().SetVector("float,10", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 551f, 1172f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}
}
