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
			HJGEHJDMCGI().SetFloat("sounds/no_hit", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_TimeX", Size);
			OLHDPICFBOF().SetFloat("ConnectToMaster() disabled the offline mode. No longer offline.", Fade);
			DEFBJOCJJKF().SetFloat("_TimeX", GAMMLIDAPPF);
			LNLKMDPHDCC().SetVector("Map id for", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1879f, 284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DABHAJNHOAL());
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
			PDEAHJPOMEF().SetFloat("OnMastedChangeScene", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("]", Size);
			DEFBJOCJJKF().SetFloat("PunPickupSimple", Fade);
			KEMAALEODNH().SetFloat("settings.volume.menu", GAMMLIDAPPF);
			GCDFNHMJMIP().SetVector("???", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 463f, 1232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			GCDFNHMJMIP().SetFloat("MenuPlayButton", HBJJOCHGOPH);
			HBLDMJCOAHA().SetFloat("Parent ID", Size);
			HNFFHCLNBDN().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", Fade);
			NBPKMLMCHFN.SetFloat("_Amount", GAMMLIDAPPF);
			PLBEJJIHFPB().SetVector("#tryagain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1386f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			HNFFHCLNBDN().SetFloat("Indie", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("<command>", Size);
			IGKFMCPDNOI().SetFloat("DPADVER", Fade);
			LMLENGFLEBD().SetFloat("_Value", GAMMLIDAPPF);
			HJGEHJDMCGI().SetVector("_Threshold", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 191f, 1051f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
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
			GKILCDHJFEG().SetFloat("Loading", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("#", Size);
			KEMAALEODNH().SetFloat("#submit", Fade);
			GCDFNHMJMIP().SetFloat("0,7,true,0", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 498f, 1815f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
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
			HJGEHJDMCGI().SetFloat("_Value2", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("0,1,false", Size);
			MLMKCOINOOH().SetFloat("/icon", Fade);
			PDEAHJPOMEF().SetFloat("_Value2", GAMMLIDAPPF);
			DEFBJOCJJKF().SetVector("CameraFilterPack/Blend2Camera_Exclusion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1655f, 558f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
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
			MLMKCOINOOH().SetFloat("_Scale", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat(" while connecting to: ", Size);
			HBLDMJCOAHA().SetFloat("player.greenlifering", Fade);
			BLMPMOIDGMG().SetFloat("Set Sun Input", GAMMLIDAPPF);
			HBLDMJCOAHA().SetVector("resource", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 970f, 841f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DABHAJNHOAL());
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
		SCShader = Shader.Find("_Value2");
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
			OLHDPICFBOF().SetFloat("checkpoint", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("SupportLogger OnApplicationPause: ", Size);
			DOMEEFLPEPJ().SetFloat("_Far", Fade);
			NBPKMLMCHFN.SetFloat("Editor", GAMMLIDAPPF);
			ADGHJOHKEHG().SetVector("Received RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 157f, 1086f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			KEMAALEODNH().SetFloat(" SecondsBeforeRespawn: ", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_EmissionGain", Size);
			KBOPGONOCNP().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", Fade);
			IGKFMCPDNOI().SetFloat("settings.shaders.bloomintencity", GAMMLIDAPPF);
			DABHAJNHOAL().SetVector("Set particles count per one beat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1463f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			HNFFHCLNBDN().SetFloat("_History1ChromaTex", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("blue", Size);
			KBOPGONOCNP().SetFloat("SupportLogger OnApplicationPause: ", Fade);
			BLMPMOIDGMG().SetFloat("MapEnd", GAMMLIDAPPF);
			KBOPGONOCNP().SetVector("</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 80f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
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
		SCShader = Shader.Find("[PlayerController] ");
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
			DEFBJOCJJKF().SetFloat("_MainTex2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", Size);
			ECCPAOBFDKP().SetFloat("_EmissionColor", Fade);
			PDEAHJPOMEF().SetFloat("settings_bindings_controller_type", GAMMLIDAPPF);
			OLHDPICFBOF().SetVector("1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 967f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			DEFBJOCJJKF().SetFloat("clicked ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_WideScreenHorizontal", Size);
			PEIMCBBHLBJ().SetFloat("grid", Fade);
			MLMKCOINOOH().SetFloat("_SizeY", GAMMLIDAPPF);
			PDEAHJPOMEF().SetVector("EndlessLoopsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 793f, 164f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			PDEAHJPOMEF().SetFloat("Failed to Destroy objects of playerId: ", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Spawn new environment object (sun, satellite etc) and sets its id", Size);
			GCDFNHMJMIP().SetFloat("_Value2", Fade);
			OLHDPICFBOF().SetFloat("yyyy-MM-dd HH:mm:ss", GAMMLIDAPPF);
			KEMAALEODNH().SetVector("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 189f, 1965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
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
			LMLENGFLEBD().SetFloat("cancel", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("_DotSize", Size);
			PLBEJJIHFPB().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", Fade);
			PLBEJJIHFPB().SetFloat("Adreno", GAMMLIDAPPF);
			DABHAJNHOAL().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1271f, 1335f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("AddEnvironmentSprite");
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
			KEMAALEODNH().SetFloat("settings.arcshitsoundtimedelay", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Size);
			LPCHMEKDCHI().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", Fade);
			INOBFNCKFGK().SetFloat("_Speed", GAMMLIDAPPF);
			LPCHMEKDCHI().SetVector("PlaySound", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 515f, 1306f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Glitch2");
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
			LMLENGFLEBD().SetFloat("CameraFilterPack/FX_Grid", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("OK", Size);
			ECCPAOBFDKP().SetFloat("ChangeSelectedLevel", Fade);
			HNFFHCLNBDN().SetFloat("_Value3", GAMMLIDAPPF);
			DOMEEFLPEPJ().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1220f, 524f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			HJGEHJDMCGI().SetFloat("SelectorMapsCountSlider", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat(".lastCheckpoint.currentCombo", Size);
			GKILCDHJFEG().SetFloat("\"", Fade);
			PEIMCBBHLBJ().SetFloat(",", GAMMLIDAPPF);
			HKGAONMOBMH().SetVector("CameraFilterPack/Broken_Screen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1385f, 1824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("intensity");
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
		SCShader = Shader.Find("CameraFilterPack/Light_Water2");
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
			PEIMCBBHLBJ().SetFloat("masterSteamID", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("BitsData", Size);
			GCDFNHMJMIP().SetFloat("_Size", Fade);
			HKGAONMOBMH().SetFloat("offsets", GAMMLIDAPPF);
			GCDFNHMJMIP().SetVector("[PlayerBase] Loaded spawner data", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 535f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DABHAJNHOAL());
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
			MLMKCOINOOH().SetFloat("_MainTex2", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_ScreenResolution", Size);
			NBPKMLMCHFN.SetFloat("Source: ", Fade);
			LPCHMEKDCHI().SetFloat("mapselector.filter.favoriteonly", GAMMLIDAPPF);
			PEIMCBBHLBJ().SetVector("[PlayerBase] Loading checkpoint data", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 515f, 1275f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find(":</b> ");
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
			INOBFNCKFGK().SetFloat("ArcsHitsoundTimeDelaySlider", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("settings.volume.sfx", Size);
			PHGCJOPFDOG().SetFloat(" ", Fade);
			BLMPMOIDGMG().SetFloat("_CurveParams", GAMMLIDAPPF);
			PEIMCBBHLBJ().SetVector(" Kb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1612f, 239f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			PDEAHJPOMEF().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("\\n", Size);
			GKILCDHJFEG().SetFloat("_Value3", Fade);
			PDEAHJPOMEF().SetFloat("_SSAO", GAMMLIDAPPF);
			GKILCDHJFEG().SetVector("ItemNameBGImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1499f, 1240f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("Object ID. Case-Sensitive");
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
			BLMPMOIDGMG().SetFloat("_Value4", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat(".mp3", Size);
			ECCPAOBFDKP().SetFloat(" ", Fade);
			OLHDPICFBOF().SetFloat("Can't set open when not in that room.", GAMMLIDAPPF);
			HKGAONMOBMH().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 942f, 442f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			LNLKMDPHDCC().SetFloat("_DepthLevel", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_TimeX", Size);
			GCDFNHMJMIP().SetFloat("_GrainTex", Fade);
			LPCHMEKDCHI().SetFloat("SetRoomStartTimestamp", GAMMLIDAPPF);
			GCDFNHMJMIP().SetVector("]. Please verify you have this gameobject in a Resources folder.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1926f, 1608f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("GlassesColor");
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
			DEFBJOCJJKF().SetFloat("menu.playedpage", HBJJOCHGOPH);
			DABHAJNHOAL().SetFloat("id", Size);
			DABHAJNHOAL().SetFloat("delete", Fade);
			LNLKMDPHDCC().SetFloat("_MainTex2", GAMMLIDAPPF);
			KEMAALEODNH().SetVector(" Mb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1599f, 189f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
		SCShader = Shader.Find("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);");
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
		SCShader = Shader.Find("_Radius2");
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
			PHGCJOPFDOG().SetFloat("Lerp speed. Recomended 10", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("_SizeY", Size);
			DABHAJNHOAL().SetFloat("Set Sun Sensitivity", Fade);
			EBJKJPAIAAM().SetFloat("icon.png", GAMMLIDAPPF);
			DEFBJOCJJKF().SetVector("_Size", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 1194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("_Offsets");
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
			LNLKMDPHDCC().SetFloat("_TimeX", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("Joined room ", Size);
			NBMPPNFKFLB().SetFloat("SetSunLerpSpeed", Fade);
			GCDFNHMJMIP().SetFloat("_StretchWidth", GAMMLIDAPPF);
			KBOPGONOCNP().SetVector("SAVE", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 81f, 553f));
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
		SCShader = Shader.Find("R2");
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
		SCShader = Shader.Find("float,0");
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
		SCShader = Shader.Find("_ScreenResolution");
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
			KBOPGONOCNP().SetFloat("help", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_RGB", Size);
			MLMKCOINOOH().SetFloat("note.6", Fade);
			HJGEHJDMCGI().SetFloat("CameraFilterPack/3D_Computer", GAMMLIDAPPF);
			ADBKPGFMNKO().SetVector("RenderTextureUtilityTempTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 483f, 605f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("_SecondTex");
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
		SCShader = Shader.Find("ShadersToggle");
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
			LMLENGFLEBD().SetFloat("_TimeX", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("$ {0}", Size);
			NBMPPNFKFLB().SetFloat("Hidden/ScreenSpaceReflection", Fade);
			ECCPAOBFDKP().SetFloat("_ScreenResolution", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("STICKRHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 236f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			HBLDMJCOAHA().SetFloat("_UserLutTex", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("ShowSprite", Size);
			MLMKCOINOOH().SetFloat("_Speed", Fade);
			OLHDPICFBOF().SetFloat("[MenuScene] Error: ", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("s", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1950f, 1212f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
			NBPKMLMCHFN.SetFloat("/Segment-[Right]", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("_TimeX", Size);
			DEFBJOCJJKF().SetFloat("menu.copyright", Fade);
			DEFBJOCJJKF().SetFloat("_LutTex", GAMMLIDAPPF);
			EBJKJPAIAAM().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1401f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			GCDFNHMJMIP().SetFloat("#news", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("Committing changes...", Size);
			NBPKMLMCHFN.SetFloat("/../", Fade);
			HNFFHCLNBDN().SetFloat("settings_bindings_", GAMMLIDAPPF);
			NBMPPNFKFLB().SetVector("_BlurRadius4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 369f, 1830f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			PEIMCBBHLBJ().SetFloat("PLEASE WAIT", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("BloomShaderValueSlider", Size);
			BLMPMOIDGMG().SetFloat("BitsData", Fade);
			LNLKMDPHDCC().SetFloat("Bad parameters for set! Use <language>", GAMMLIDAPPF);
			LMLENGFLEBD().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1113f, 1663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("/");
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
		SCShader = Shader.Find("Joystick1Button7");
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
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("D-Pad Up");
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
			INOBFNCKFGK().SetFloat("StartTime already set: ", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat(" Server: ", Size);
			LNLKMDPHDCC().SetFloat("#ok", Fade);
			NBMPPNFKFLB().SetFloat("_EmissionColor", GAMMLIDAPPF);
			HBLDMJCOAHA().SetVector("STICKRVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1080f, 546f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("Emergency Help:");
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
		SCShader = Shader.Find("UnityEngine.MonoBehaviour");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find(".lastCheckpoint.bgcolor");
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
		SCShader = Shader.Find("ItemsUploader");
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
		SCShader = Shader.Find("visible");
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
			OLHDPICFBOF().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			HBLDMJCOAHA().SetFloat("DifficultyBG", Size);
			PEIMCBBHLBJ().SetFloat(" = ", Fade);
			LPCHMEKDCHI().SetFloat("Drop_With_Obj", GAMMLIDAPPF);
			LNLKMDPHDCC().SetVector("skin.hit_perfect", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 900f, 816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
		SCShader = Shader.Find("Xbox Home");
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
			KBOPGONOCNP().SetFloat("Set particles start speed", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_Blue_C", Size);
			ECCPAOBFDKP().SetFloat("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", Fade);
			BLMPMOIDGMG().SetFloat("ERROR: mod directory not found!", GAMMLIDAPPF);
			KEMAALEODNH().SetVector("_VignetteSettings", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1609f, 1868f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			MLMKCOINOOH().SetFloat("?", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("2hands", Size);
			INOBFNCKFGK().SetFloat("ChallengesButton", Fade);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Pixelisation_Dot", GAMMLIDAPPF);
			INOBFNCKFGK().SetVector("s", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1744f, 731f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			ADGHJOHKEHG().SetFloat("Internal LUT", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Folk", Size);
			HBLDMJCOAHA().SetFloat("_TimeX", Fade);
			DEFBJOCJJKF().SetFloat("_Bullet_10", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 551f, 1172f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
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
