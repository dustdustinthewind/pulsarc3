// CameraFilterPack_NightVisionFX
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision FX")]
public class CameraFilterPack_NightVisionFX : MonoBehaviour
{
	public enum preset
	{
		Night_Vision_Personalized = -1,
		Night_Vision_FX,
		Night_Vision_Classic,
		Night_Vision_Full,
		Night_Vision_Dark,
		Night_Vision_Sharp,
		Night_Vision_BlueSky,
		Night_Vision_Low_Light,
		Night_Vision_Pinky,
		Night_Vision_RedBurn,
		Night_Vision_PurpleShadow
	}

	public Shader SCShader;

	public preset Preset;

	private preset HODDOPANHAO;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float OnOff;

	[Range(0.2f, 2f)]
	public float Greenness = 1f;

	[Range(0f, 1f)]
	public float Vignette = 1f;

	[Range(0f, 1f)]
	public float Vignette_Alpha = 1f;

	[Range(-10f, 10f)]
	public float Distortion = 1f;

	[Range(0f, 1f)]
	public float Noise = 1f;

	[Range(-2f, 1f)]
	public float Intensity = -1f;

	[Range(0f, 2f)]
	public float Light = 1f;

	[Range(0f, 1f)]
	public float Light2 = 1f;

	[Range(0f, 2f)]
	public float Line = 1f;

	[Range(-2f, 2f)]
	public float Color_R;

	[Range(-2f, 2f)]
	public float Color_G;

	[Range(-2f, 2f)]
	public float Color_B;

	[Range(0f, 1f)]
	public float _Binocular_Size = 0.499f;

	[Range(0f, 1f)]
	public float _Binocular_Smooth = 0.113f;

	[Range(0f, 1f)]
	public float _Binocular_Dist = 0.286f;

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

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1028f)
			{
				HBJJOCHGOPH = 206f;
			}
			IONHGBPGCHK().SetFloat("<b>#banended</b>", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("settings.arcshitsoundtimedelay", OnOff);
			MLMKCOINOOH().SetFloat("SetSatelliteLerpSpeed", Greenness);
			DEFBJOCJJKF().SetFloat("[MenuScene] Error: ", Vignette);
			KEMJNOMIPHN().SetFloat("Preparing content", Vignette_Alpha);
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", Distortion);
			MLMKCOINOOH().SetFloat("Missing shader in ", Noise);
			MICHFGAOPKM().SetFloat("Vertical", Intensity);
			KEMJNOMIPHN().SetFloat("COMPLETED", Light);
			KEMJNOMIPHN().SetFloat("Scrollbar", Light2);
			LENEJAGLCNL().SetFloat("\\\\", Line);
			MLMKCOINOOH().SetFloat("x", Color_R);
			IFMAPIDFNLI().SetFloat("ResourceIDInputField", Color_G);
			IFMAPIDFNLI().SetFloat("LevelConfigButton", Color_B);
			GJHLADDCMFF().SetFloat("Tab1Content", _Binocular_Size);
			IONHGBPGCHK().SetFloat("Object ID. Case-Sensitive", _Binocular_Dist);
			DKNJGHFLAIF().SetFloat("file://", _Binocular_Smooth);
			OIMMPLPBLBK().SetVector("CameraFilterPack/BlurHole", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONKDMMJPEMN()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[127];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[80];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[-36];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-75];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-17];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[98];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[-61];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[11]
			{
				2f, 0.054f, 1f, 1.28f, 0.409f, -1f, 0.41f, 0.656f, 0.427f, 0.95f,
				-0.35f
			};
			float[] array16 = new float[-22];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array17 = array16;
			float[] array18 = new float[-20];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array19 = array18;
			float[] array20 = new float[42];
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array4;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array20 = array6;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array20 = array8;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array20 = array10;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array12;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array20 = array14;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array20 = array15;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array17;
			}
			if (Preset == (preset)77)
			{
				array20 = array19;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array20[1];
				Vignette = array20[1];
				Vignette_Alpha = array20[8];
				Distortion = array20[5];
				Noise = array20[4];
				Intensity = array20[6];
				Light = array20[6];
				Light2 = array20[4];
				Line = array20[2];
				Color_R = array20[-49];
				Color_G = array20[5];
				Color_B = array20[21];
			}
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/NightVisionFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1257f)
			{
				HBJJOCHGOPH = 929f;
			}
			KBOPGONOCNP().SetFloat("string", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("/icon", OnOff);
			MLMKCOINOOH().SetFloat("LastNewsButton", Greenness);
			GJHLADDCMFF().SetFloat("_Color_R", Vignette);
			MLMKCOINOOH().SetFloat("#FFDA44", Vignette_Alpha);
			DEFBJOCJJKF().SetFloat(" ", Distortion);
			LENEJAGLCNL().SetFloat(".lastCheckpoint.playerdistance", Noise);
			LENEJAGLCNL().SetFloat("st", Intensity);
			IONHGBPGCHK().SetFloat("colorD", Light);
			EOCCJGIGEGJ().SetFloat("mapselector.tags.", Light2);
			MICHFGAOPKM().SetFloat("history", Line);
			KBOPGONOCNP().SetFloat("AvatarImage", Color_R);
			NBPKMLMCHFN.SetFloat("win", Color_G);
			DKNJGHFLAIF().SetFloat("_PColor", Color_B);
			NBPKMLMCHFN.SetFloat("InstantiateRpc", _Binocular_Size);
			IFMAPIDFNLI().SetFloat(".completed", _Binocular_Dist);
			MLMKCOINOOH().SetFloat("OnMastedChangeScene", _Binocular_Smooth);
			KBOPGONOCNP().SetVector("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 545f)
			{
				HBJJOCHGOPH = 536f;
			}
			IFMAPIDFNLI().SetFloat("_Value3", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("ServerSettings: ", OnOff);
			DEFBJOCJJKF().SetFloat("_CenterX", Greenness);
			KEMJNOMIPHN().SetFloat("#kicked", Vignette);
			IFMAPIDFNLI().SetFloat("CameraFilterPack/Light_Water2", Vignette_Alpha);
			DEFBJOCJJKF().SetFloat("_FarCamera", Distortion);
			DKNJGHFLAIF().SetFloat("Bad parameters for getbool! Use <key> <value>", Noise);
			DOHGBNPMBKG().SetFloat("SetSunSensitivity", Intensity);
			MICHFGAOPKM().SetFloat("Waiting for AvailableRegions. State: ", Light);
			IONHGBPGCHK().SetFloat("mapselector.filter.favoriteonly", Light2);
			MCDGIILBNIF().SetFloat(" not exist", Line);
			LENEJAGLCNL().SetFloat("SetSpeed", Color_R);
			IONHGBPGCHK().SetFloat("12", Color_G);
			MLMKCOINOOH().SetFloat("SetScale", Color_B);
			LENEJAGLCNL().SetFloat("JoinButton", _Binocular_Size);
			MCDGIILBNIF().SetFloat("_SecondTex", _Binocular_Dist);
			HKGAONMOBMH().SetFloat("a month ago", _Binocular_Smooth);
			IFMAPIDFNLI().SetVector("#alreadyexist", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[12]
			{
				0.757f, 0.098f, 0.458f, -2.49f, 0.559f, -0.298f, 1.202f, 0.515f, 1f, 0f,
				0f, 0f
			};
			float[] array2 = new float[12]
			{
				0.2f, 0.202f, 0.68f, -1.49f, 0.084f, -0.019f, 2f, 0.166f, 1.948f, -0.1f,
				0.15f, -0.07f
			};
			float[] array3 = new float[12]
			{
				1.45f, 0.01f, 0.112f, -0.07f, 0.111f, -0.077f, 0.071f, 0f, 0.245f, 0f,
				0f, 0f
			};
			float[] array4 = new float[12]
			{
				0.779f, 0.185f, 0.706f, 1.21f, 0.24f, 0.138f, 2f, 0.07f, 1.224f, -0.21f,
				-0.34f, 0f
			};
			float[] array5 = new float[12]
			{
				0.2f, 0.028f, 0.706f, 1.21f, 0.397f, -0.24f, 2f, 0.298f, 1.224f, -0.08f,
				0.48f, -0.57f
			};
			float[] array6 = new float[12]
			{
				0.2f, 0.159f, 0.622f, -2.28f, 0.409f, -0.24f, 0.166f, 0.028f, 2f, -0.08f,
				0.22f, 0.57f
			};
			float[] array7 = new float[12]
			{
				2f, 0.054f, 1f, -2.28f, 0.409f, -1f, 2f, 0.187f, 0.241f, 0f,
				1.58f, 0.21f
			};
			float[] array8 = new float[12]
			{
				2f, 0.054f, 1f, 1.28f, 0.409f, -1f, 0.41f, 0.656f, 0.427f, 0.95f,
				-0.35f, 1.41f
			};
			float[] array9 = new float[12]
			{
				2f, 0.281f, 0.156f, 1.85f, 0.709f, -1f, 0.41f, 0.109f, 0.34f, 0.95f,
				0.36f, -0.14f
			};
			float[] array10 = new float[12]
			{
				0.905f, 0.281f, 0.156f, 1.85f, 0.558f, -0.974f, 1.639f, 0.252f, 1.074f, 0.46f,
				0.95f, 0.58f
			};
			float[] array11 = new float[12];
			if (Preset == preset.Night_Vision_FX)
			{
				array11 = array;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array11 = array2;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array11 = array3;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array11 = array4;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array11 = array5;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array11 = array6;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array11 = array7;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array11 = array8;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array11 = array9;
			}
			if (Preset == preset.Night_Vision_PurpleShadow)
			{
				array11 = array10;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array11[0];
				Vignette = array11[1];
				Vignette_Alpha = array11[2];
				Distortion = array11[3];
				Noise = array11[4];
				Intensity = array11[5];
				Light = array11[6];
				Light2 = array11[7];
				Line = array11[8];
				Color_R = array11[9];
				Color_G = array11[10];
				Color_B = array11[11];
			}
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1880f)
			{
				HBJJOCHGOPH = 1299f;
			}
			KBOPGONOCNP().SetFloat("[MapEditor] Updating top menu", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat(" on effect ", OnOff);
			MCDGIILBNIF().SetFloat("_Line", Greenness);
			MLMKCOINOOH().SetFloat(" (inactive)", Vignette);
			NBPKMLMCHFN.SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", Vignette_Alpha);
			OIMMPLPBLBK().SetFloat(",", Distortion);
			MCDGIILBNIF().SetFloat("\n", Noise);
			DKNJGHFLAIF().SetFloat("Command not found!", Intensity);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Light_Rainbow", Light);
			DEFBJOCJJKF().SetFloat("FinalScoreText", Light2);
			DOHGBNPMBKG().SetFloat("LevelInfoInputField", Line);
			GJHLADDCMFF().SetFloat("PublishButton", Color_R);
			DOHGBNPMBKG().SetFloat("CameraFilterPack_TV_Noise2", Color_G);
			DEFBJOCJJKF().SetFloat("menu.relaxinfo", Color_B);
			IONHGBPGCHK().SetFloat("closed", _Binocular_Size);
			MLMKCOINOOH().SetFloat("_ScreenResolution", _Binocular_Dist);
			LENEJAGLCNL().SetFloat("_Value9", _Binocular_Smooth);
			GJHLADDCMFF().SetVector("?", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void IDIIELPAMCJ()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-110];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[96];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[20];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-80];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[44];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[-5];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[47];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[-82];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[71];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-88];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[-30];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (Preset == (preset)(-58))
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[1];
				Vignette = array21[0];
				Vignette_Alpha = array21[8];
				Distortion = array21[6];
				Noise = array21[3];
				Intensity = array21[1];
				Light = array21[7];
				Light2 = array21[5];
				Line = array21[0];
				Color_R = array21[-126];
				Color_G = array21[-116];
				Color_B = array21[-4];
			}
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 767f)
			{
				HBJJOCHGOPH = 962f;
			}
			MCDGIILBNIF().SetFloat("float,10", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("mapselector.filter.favoriteonly", OnOff);
			MICHFGAOPKM().SetFloat("float,0", Greenness);
			DOHGBNPMBKG().SetFloat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", Vignette);
			MCDGIILBNIF().SetFloat("quit", Vignette_Alpha);
			MICHFGAOPKM().SetFloat("ResetButton", Distortion);
			MICHFGAOPKM().SetFloat("_Offsets", Noise);
			GJHLADDCMFF().SetFloat("OK", Intensity);
			MICHFGAOPKM().SetFloat("Failed to 'GetKeyCode' for key: ", Light);
			KEMJNOMIPHN().SetFloat("0.00", Light2);
			GJHLADDCMFF().SetFloat("settings.volume.game", Line);
			GJHLADDCMFF().SetFloat("In Main Menu", Color_R);
			DEFBJOCJJKF().SetFloat("Save", Color_G);
			MCDGIILBNIF().SetFloat("0,2,true,0", Color_B);
			MICHFGAOPKM().SetFloat("Object ID. Case-Sensitive", _Binocular_Size);
			IFMAPIDFNLI().SetFloat("_TimeX", _Binocular_Dist);
			MLMKCOINOOH().SetFloat("NameText", _Binocular_Smooth);
			LENEJAGLCNL().SetVector("Set sun audio input", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AAPKBNDHBLI()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[55];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-46];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[-67];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-114];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[56];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[123];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[13];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[87];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[80];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-54];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[45];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array18;
			}
			if (Preset == (preset)(-70))
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[0];
				Vignette = array21[1];
				Vignette_Alpha = array21[5];
				Distortion = array21[7];
				Noise = array21[6];
				Intensity = array21[1];
				Light = array21[1];
				Light2 = array21[5];
				Line = array21[0];
				Color_R = array21[-102];
				Color_G = array21[97];
				Color_B = array21[103];
			}
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("float,40");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("shader.pixel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("LB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("_CameraClipInfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 795f)
			{
				HBJJOCHGOPH = 1833f;
			}
			DKNJGHFLAIF().SetFloat("_MainTex2", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("[ItemsHandler] Loading Steam inventory", OnOff);
			IFMAPIDFNLI().SetFloat("Have you fully accept the terms?", Greenness);
			EOCCJGIGEGJ().SetFloat("_Value8", Vignette);
			LENEJAGLCNL().SetFloat("_SphereSize", Vignette_Alpha);
			KBOPGONOCNP().SetFloat("_Blurred", Distortion);
			HKGAONMOBMH().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", Noise);
			IONHGBPGCHK().SetFloat("(master)", Intensity);
			MCDGIILBNIF().SetFloat("IconImage", Light);
			NBPKMLMCHFN.SetFloat("clear", Light2);
			NBPKMLMCHFN.SetFloat("_Value", Line);
			NBPKMLMCHFN.SetFloat("EventSystem", Color_R);
			IFMAPIDFNLI().SetFloat("Fade", Color_G);
			MLMKCOINOOH().SetFloat("Rap", Color_B);
			DKNJGHFLAIF().SetFloat("PunPickupSimple", _Binocular_Size);
			DKNJGHFLAIF().SetFloat("OxOD.lastPath", _Binocular_Dist);
			MLMKCOINOOH().SetFloat("\n", _Binocular_Smooth);
			NBPKMLMCHFN.SetVector("settings_bindings_controller_type", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("Misses:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 244f)
			{
				HBJJOCHGOPH = 1406f;
			}
			KEMJNOMIPHN().SetFloat("player.redabstract", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("DPADVER", OnOff);
			DKNJGHFLAIF().SetFloat("_Value", Greenness);
			KEMJNOMIPHN().SetFloat("_Value2", Vignette);
			DOHGBNPMBKG().SetFloat("ViewMenu", Vignette_Alpha);
			DKNJGHFLAIF().SetFloat("menu.enableselectormusic", Distortion);
			MICHFGAOPKM().SetFloat("  |  Events Count: ", Noise);
			HKGAONMOBMH().SetFloat("Using constructor for new PingNativeStatic()", Intensity);
			IONHGBPGCHK().SetFloat(". The RPC has been ignored.", Light);
			NBPKMLMCHFN.SetFloat("bad", Light2);
			IFMAPIDFNLI().SetFloat("_BlendTex", Line);
			KBOPGONOCNP().SetFloat("BitsData", Color_R);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Drawing_Toon", Color_G);
			MICHFGAOPKM().SetFloat("ShadersToggle", Color_B);
			LENEJAGLCNL().SetFloat("Tab2Content", _Binocular_Size);
			LENEJAGLCNL().SetFloat("...", _Binocular_Dist);
			HKGAONMOBMH().SetFloat("BitsData", _Binocular_Smooth);
			HKGAONMOBMH().SetVector("_Red_B", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IIFCIDDJHPM()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[103];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-5];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[3] { 1.45f, 0.01f, 0.112f };
			float[] array6 = new float[126];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array7 = array6;
			float[] array8 = new float[-35];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array9 = array8;
			float[] array10 = new float[79];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array11 = array10;
			float[] array12 = new float[50];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array13 = array12;
			float[] array14 = new float[-2];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array15 = array14;
			float[] array16 = new float[59];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array17 = array16;
			float[] array18 = new float[43];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array19 = array18;
			float[] array20 = new float[-23];
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array4;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array5;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array7;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array9;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array20 = array11;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array13;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array20 = array15;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array17;
			}
			if (Preset == (preset)96)
			{
				array20 = array19;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array20[0];
				Vignette = array20[1];
				Vignette_Alpha = array20[4];
				Distortion = array20[6];
				Noise = array20[0];
				Intensity = array20[5];
				Light = array20[2];
				Light2 = array20[8];
				Line = array20[6];
				Color_R = array20[-48];
				Color_G = array20[52];
				Color_B = array20[-127];
			}
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("sfxVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNDNDPECBPL()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-39];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[24];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[110];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-66];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[103];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[-74];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[-28];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[-34];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[91];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-77];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[27];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array18;
			}
			if (Preset == (preset)15)
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[0];
				Vignette = array21[1];
				Vignette_Alpha = array21[3];
				Distortion = array21[1];
				Noise = array21[5];
				Intensity = array21[8];
				Light = array21[4];
				Light2 = array21[4];
				Line = array21[6];
				Color_R = array21[42];
				Color_G = array21[-36];
				Color_B = array21[24];
			}
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("Updated!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGMJDGHLBMN()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-71];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-117];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[-23];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[42];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-86];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[36];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[100];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[65];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[91];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-15];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[-28];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (Preset == (preset)36)
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[1];
				Vignette = array21[1];
				Vignette_Alpha = array21[4];
				Distortion = array21[0];
				Noise = array21[5];
				Intensity = array21[8];
				Light = array21[7];
				Light2 = array21[8];
				Line = array21[4];
				Color_R = array21[82];
				Color_G = array21[91];
				Color_B = array21[-111];
			}
		}
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("Scale environment object by the values");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FOLDLDLFFLM()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[65];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[76];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[34];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-116];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-1];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[68];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[32];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[-107];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[-106];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-107];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[-82];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array18;
			}
			if (Preset == (preset)89)
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[0];
				Vignette = array21[0];
				Vignette_Alpha = array21[2];
				Distortion = array21[6];
				Noise = array21[4];
				Intensity = array21[0];
				Light = array21[3];
				Light2 = array21[4];
				Line = array21[4];
				Color_R = array21[-20];
				Color_G = array21[2];
				Color_B = array21[41];
			}
		}
	}

	private void KCDOMIJBFLL()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-9];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-60];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[82];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-21];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-44];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[37];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[-108];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[65];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[75];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-33];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[-55];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (Preset == (preset)46)
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[1];
				Vignette = array21[1];
				Vignette_Alpha = array21[5];
				Distortion = array21[2];
				Noise = array21[0];
				Intensity = array21[8];
				Light = array21[7];
				Light2 = array21[0];
				Line = array21[3];
				Color_R = array21[8];
				Color_G = array21[50];
				Color_B = array21[-25];
			}
		}
	}

	private void EGEGNHLODAA()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-64];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-13];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[-6];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[63];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[70];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[57];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[84];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[-7];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[-60];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-105];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[59];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array18;
			}
			if (Preset == (preset)(-86))
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[0];
				Vignette = array21[0];
				Vignette_Alpha = array21[6];
				Distortion = array21[5];
				Noise = array21[7];
				Intensity = array21[4];
				Light = array21[8];
				Light2 = array21[8];
				Line = array21[4];
				Color_R = array21[-105];
				Color_G = array21[40];
				Color_B = array21[76];
			}
		}
	}

	private void OEENOOGEEHD()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[88];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-19];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[22];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[58];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-112];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[-114];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[41];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[-127];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[-106];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-98];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[-25];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array18;
			}
			if (Preset == (preset)(-125))
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[0];
				Vignette = array21[1];
				Vignette_Alpha = array21[8];
				Distortion = array21[4];
				Noise = array21[4];
				Intensity = array21[7];
				Light = array21[3];
				Light2 = array21[6];
				Line = array21[1];
				Color_R = array21[-80];
				Color_G = array21[83];
				Color_B = array21[4];
			}
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 495f)
			{
				HBJJOCHGOPH = 737f;
			}
			LENEJAGLCNL().SetFloat(" not exist", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("SpawnObj", OnOff);
			KEMJNOMIPHN().SetFloat("1", Greenness);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/EyesVision_1", Vignette);
			LENEJAGLCNL().SetFloat("Set satellite audio input", Vignette_Alpha);
			IONHGBPGCHK().SetFloat("_CameraWS", Distortion);
			NBPKMLMCHFN.SetFloat("Select", Noise);
			DEFBJOCJJKF().SetFloat(" not exist", Intensity);
			EOCCJGIGEGJ().SetFloat(" not exist", Light);
			IFMAPIDFNLI().SetFloat("_ScreenResolution", Light2);
			LENEJAGLCNL().SetFloat("HandsCountSlider", Line);
			MICHFGAOPKM().SetFloat(": ", Color_R);
			MLMKCOINOOH().SetFloat("settings_bindings_controller_type", Color_G);
			OIMMPLPBLBK().SetFloat("_Value", Color_B);
			MCDGIILBNIF().SetFloat("EnableRankingToggle", _Binocular_Size);
			DEFBJOCJJKF().SetFloat("Offline or in OfflineMode. No VitalStats available.", _Binocular_Dist);
			DKNJGHFLAIF().SetFloat("Texture3", _Binocular_Smooth);
			NBPKMLMCHFN.SetVector("mapselector.tags.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("_WorldToCameraMatrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("AvatarImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KMEONPMCNJG()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-19];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-14];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[86];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[48];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-68];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[80];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[110];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[126];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[-38];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[-81];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[69];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (Preset == (preset)(-2))
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[1];
				Vignette = array21[0];
				Vignette_Alpha = array21[7];
				Distortion = array21[7];
				Noise = array21[4];
				Intensity = array21[0];
				Light = array21[6];
				Light2 = array21[8];
				Line = array21[3];
				Color_R = array21[12];
				Color_G = array21[42];
				Color_B = array21[-84];
			}
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
			NBPKMLMCHFN.SetFloat("_OnOff", OnOff);
			NBPKMLMCHFN.SetFloat("_Greenness", Greenness);
			NBPKMLMCHFN.SetFloat("_Vignette", Vignette);
			NBPKMLMCHFN.SetFloat("_Vignette_Alpha", Vignette_Alpha);
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetFloat("_Noise", Noise);
			NBPKMLMCHFN.SetFloat("_Intensity", Intensity);
			NBPKMLMCHFN.SetFloat("_Light", Light);
			NBPKMLMCHFN.SetFloat("_Light2", Light2);
			NBPKMLMCHFN.SetFloat("_Line", Line);
			NBPKMLMCHFN.SetFloat("_Color_R", Color_R);
			NBPKMLMCHFN.SetFloat("_Color_G", Color_G);
			NBPKMLMCHFN.SetFloat("_Color_B", Color_B);
			NBPKMLMCHFN.SetFloat("_Size", _Binocular_Size);
			NBPKMLMCHFN.SetFloat("_Dist", _Binocular_Dist);
			NBPKMLMCHFN.SetFloat("_Smooth", _Binocular_Smooth);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PNLKFANNOKO()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[31];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-25];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[2] { 1.45f, 0.01f };
			float[] array6 = new float[-2];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array7 = array6;
			float[] array8 = new float[-112];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array9 = array8;
			float[] array10 = new float[47];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array11 = array10;
			float[] array12 = new float[68];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array13 = array12;
			float[] array14 = new float[-79];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array15 = array14;
			float[] array16 = new float[73];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array17 = array16;
			float[] array18 = new float[-95];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array19 = array18;
			float[] array20 = new float[5];
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array4;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array5;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array20 = array7;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array9;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array20 = array11;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array13;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array15;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array17;
			}
			if (Preset == (preset)45)
			{
				array20 = array19;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array20[1];
				Vignette = array20[1];
				Vignette_Alpha = array20[4];
				Distortion = array20[8];
				Noise = array20[4];
				Intensity = array20[6];
				Light = array20[5];
				Light2 = array20[6];
				Line = array20[7];
				Color_R = array20[58];
				Color_G = array20[-105];
				Color_B = array20[40];
			}
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1437f)
			{
				HBJJOCHGOPH = 1143f;
			}
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/TV_Vintage", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat(".completed", OnOff);
			DEFBJOCJJKF().SetFloat("#,0.00", Greenness);
			OIMMPLPBLBK().SetFloat("_PositionX", Vignette);
			HKGAONMOBMH().SetFloat(" GO:", Vignette_Alpha);
			IONHGBPGCHK().SetFloat("_TimeX", Distortion);
			OIMMPLPBLBK().SetFloat("ItemNameBGImage", Noise);
			NBPKMLMCHFN.SetFloat("_Value4", Intensity);
			KEMJNOMIPHN().SetFloat("Move environment object to the position", Light);
			IFMAPIDFNLI().SetFloat("_Value2", Light2);
			EOCCJGIGEGJ().SetFloat("player.redlifering", Line);
			DEFBJOCJJKF().SetFloat("Lerp speed. Recomended 10", Color_R);
			DOHGBNPMBKG().SetFloat("maps.", Color_G);
			MCDGIILBNIF().SetFloat("Missing shader in ", Color_B);
			DOHGBNPMBKG().SetFloat("[MapsData] Preloading ", _Binocular_Size);
			DOHGBNPMBKG().SetFloat("\" for viewID ", _Binocular_Dist);
			KEMJNOMIPHN().SetFloat("(\\[ */ *b *\\])", _Binocular_Smooth);
			KEMJNOMIPHN().SetVector("/Segment-[Left]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1047f)
			{
				HBJJOCHGOPH = 1048f;
			}
			MCDGIILBNIF().SetFloat("open", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Joystick1Button6", OnOff);
			IONHGBPGCHK().SetFloat("_ColorKey", Greenness);
			IONHGBPGCHK().SetFloat("<i>", Vignette);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack_RainFX_Anm", Vignette_Alpha);
			IFMAPIDFNLI().SetFloat("[PlayerController] ", Distortion);
			IONHGBPGCHK().SetFloat("skin.hit_normal", Noise);
			MCDGIILBNIF().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", Intensity);
			MLMKCOINOOH().SetFloat("an hour ago", Light);
			IONHGBPGCHK().SetFloat(" base map(s)", Light2);
			GJHLADDCMFF().SetFloat("BadgeText", Line);
			DKNJGHFLAIF().SetFloat("_Offsets", Color_R);
			MCDGIILBNIF().SetFloat("_Value4", Color_G);
			OIMMPLPBLBK().SetFloat(".completed", Color_B);
			IFMAPIDFNLI().SetFloat("id", _Binocular_Size);
			KEMJNOMIPHN().SetFloat("GlassAberration", _Binocular_Dist);
			MCDGIILBNIF().SetFloat("_ColorBuffer", _Binocular_Smooth);
			KEMJNOMIPHN().SetVector("id", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("plainText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 80f)
			{
				HBJJOCHGOPH = 1342f;
			}
			DOHGBNPMBKG().SetFloat("Server: {0}. Region: {1} ", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_ScreenResolution", OnOff);
			IFMAPIDFNLI().SetFloat("SlidingArea", Greenness);
			OIMMPLPBLBK().SetFloat("_TimeX", Vignette);
			KEMJNOMIPHN().SetFloat("LevelEditor/CustomEventEditor-Text", Vignette_Alpha);
			MLMKCOINOOH().SetFloat("_ScreenResolution", Distortion);
			DOHGBNPMBKG().SetFloat("Set environment sprite color and alpha.", Noise);
			KBOPGONOCNP().SetFloat("_DistortionLevel", Intensity);
			MLMKCOINOOH().SetFloat("MusicFileSelector", Light);
			IONHGBPGCHK().SetFloat("/", Light2);
			GJHLADDCMFF().SetFloat("GroupNameText", Line);
			IONHGBPGCHK().SetFloat("_TimeX", Color_R);
			EOCCJGIGEGJ().SetFloat("[PlayerController] ", Color_G);
			KEMJNOMIPHN().SetFloat("_FarCamera", Color_B);
			IFMAPIDFNLI().SetFloat("_ToPrevViewProjCombined", _Binocular_Size);
			DOHGBNPMBKG().SetFloat("inventory.selected.", _Binocular_Dist);
			MLMKCOINOOH().SetFloat("OK", _Binocular_Smooth);
			DEFBJOCJJKF().SetVector("_Value", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1925f)
			{
				HBJJOCHGOPH = 379f;
			}
			MLMKCOINOOH().SetFloat("Not sending leave operation. State is not 'Joined': ", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("Operation ", OnOff);
			KEMJNOMIPHN().SetFloat("0,7,true,0", Greenness);
			MCDGIILBNIF().SetFloat("Myst", Vignette);
			EOCCJGIGEGJ().SetFloat(" / ", Vignette_Alpha);
			EOCCJGIGEGJ().SetFloat(" AuthMode ", Distortion);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", Noise);
			KBOPGONOCNP().SetFloat("z", Intensity);
			MCDGIILBNIF().SetFloat("settings.gamemessagesduration", Light);
			DKNJGHFLAIF().SetFloat("_Value4", Light2);
			OIMMPLPBLBK().SetFloat("achievements.21.completed.", Line);
			HKGAONMOBMH().SetFloat("#close", Color_R);
			MICHFGAOPKM().SetFloat("SSAARenderTargetCamera", Color_G);
			IFMAPIDFNLI().SetFloat("path", Color_B);
			DOHGBNPMBKG().SetFloat("FullscreenToggle", _Binocular_Size);
			KBOPGONOCNP().SetFloat("/", _Binocular_Dist);
			DOHGBNPMBKG().SetFloat("_Value", _Binocular_Smooth);
			KEMJNOMIPHN().SetVector("PossibleMapPointsText", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[61];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-83];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[-105];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-121];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-12];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[-59];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[-110];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[110];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[-66];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[15];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[-95];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Full)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array21 = array18;
			}
			if (Preset == (preset)118)
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[0];
				Vignette = array21[0];
				Vignette_Alpha = array21[6];
				Distortion = array21[6];
				Noise = array21[4];
				Intensity = array21[8];
				Light = array21[5];
				Light2 = array21[7];
				Line = array21[8];
				Color_R = array21[76];
				Color_G = array21[-78];
				Color_B = array21[-73];
			}
		}
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Drost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 427f)
			{
				HBJJOCHGOPH = 1956f;
			}
			HKGAONMOBMH().SetFloat("#,0", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("Nov", OnOff);
			KEMJNOMIPHN().SetFloat("menu.selectedplaymode", Greenness);
			EOCCJGIGEGJ().SetFloat("mapselector.filter.favoriteonly", Vignette);
			NBPKMLMCHFN.SetFloat("_UserLutParams", Vignette_Alpha);
			KEMJNOMIPHN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Distortion);
			OIMMPLPBLBK().SetFloat("ViewMenu", Noise);
			MCDGIILBNIF().SetFloat("setfloat", Intensity);
			KEMJNOMIPHN().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", Light);
			HKGAONMOBMH().SetFloat("SelectorMusicToggle", Light2);
			HKGAONMOBMH().SetFloat("DPADHOR", Line);
			KEMJNOMIPHN().SetFloat("NEW", Color_R);
			LENEJAGLCNL().SetFloat("_Blend", Color_G);
			DKNJGHFLAIF().SetFloat("Data/Editor/leveltemplate", Color_B);
			IONHGBPGCHK().SetFloat(".lastCheckpoint.checkpointsUsed", _Binocular_Size);
			HKGAONMOBMH().SetFloat("event", _Binocular_Dist);
			KEMJNOMIPHN().SetFloat("_TimeX", _Binocular_Smooth);
			OIMMPLPBLBK().SetVector("_Value5", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("[SERVER] Kicked ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("CameraFilterPack_Glasses_On6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PFNFPINPCMH()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-42];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[88];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[-76];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-3];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[-80];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[73];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array12 = array11;
			float[] array13 = new float[122];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array14 = array13;
			float[] array15 = new float[-2];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array16 = array15;
			float[] array17 = new float[-29];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array18 = array17;
			float[] array19 = new float[66];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array20 = array19;
			float[] array21 = new float[18];
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array6;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array8;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array10;
			}
			if (Preset == preset.Night_Vision_Low_Light)
			{
				array21 = array12;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array21 = array14;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array21 = array16;
			}
			if (Preset == preset.Night_Vision_Dark)
			{
				array21 = array18;
			}
			if (Preset == (preset)111)
			{
				array21 = array20;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array21[1];
				Vignette = array21[0];
				Vignette_Alpha = array21[2];
				Distortion = array21[5];
				Noise = array21[1];
				Intensity = array21[4];
				Light = array21[8];
				Light2 = array21[3];
				Line = array21[3];
				Color_R = array21[-11];
				Color_G = array21[-29];
				Color_B = array21[-99];
			}
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 162f)
			{
				HBJJOCHGOPH = 1303f;
			}
			NBPKMLMCHFN.SetFloat("Map: ", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_ScreenResolution", OnOff);
			GJHLADDCMFF().SetFloat("violet", Greenness);
			KEMJNOMIPHN().SetFloat("_ScreenResolution", Vignette);
			GJHLADDCMFF().SetFloat("_TimeX", Vignette_Alpha);
			IONHGBPGCHK().SetFloat("_DepthLevel", Distortion);
			NBPKMLMCHFN.SetFloat("_FrustumCornersWS", Noise);
			MLMKCOINOOH().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", Intensity);
			GJHLADDCMFF().SetFloat("_TimeX", Light);
			IFMAPIDFNLI().SetFloat("_MainTex2", Light2);
			NBPKMLMCHFN.SetFloat(" is muted", Line);
			EOCCJGIGEGJ().SetFloat("_color", Color_R);
			KBOPGONOCNP().SetFloat("CameraFilterPack/TV_Chromatical2", Color_G);
			MLMKCOINOOH().SetFloat("maps.", Color_B);
			EOCCJGIGEGJ().SetFloat("There is already a virtual button named ", _Binocular_Size);
			MICHFGAOPKM().SetFloat("_Value3", _Binocular_Dist);
			OIMMPLPBLBK().SetFloat("Internal LUT", _Binocular_Smooth);
			EOCCJGIGEGJ().SetVector("float,1", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHPOIOELNCG()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[-22];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-18];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[33];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[-19];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[7] { 0.2f, 0.028f, 0.706f, 1.21f, 0.397f, -0.24f, 2f };
			float[] array10 = new float[-24];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array11 = array10;
			float[] array12 = new float[34];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array13 = array12;
			float[] array14 = new float[63];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array15 = array14;
			float[] array16 = new float[-106];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array17 = array16;
			float[] array18 = new float[-17];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array19 = array18;
			float[] array20 = new float[63];
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array4;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array20 = array6;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array20 = array8;
			}
			if (Preset == preset.Night_Vision_Classic)
			{
				array20 = array9;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array20 = array11;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array13;
			}
			if (Preset == preset.Night_Vision_Pinky)
			{
				array20 = array15;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array17;
			}
			if (Preset == (preset)92)
			{
				array20 = array19;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array20[0];
				Vignette = array20[1];
				Vignette_Alpha = array20[5];
				Distortion = array20[5];
				Noise = array20[2];
				Intensity = array20[6];
				Light = array20[8];
				Light2 = array20[4];
				Line = array20[6];
				Color_R = array20[-32];
				Color_G = array20[-63];
				Color_B = array20[67];
			}
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 137f)
			{
				HBJJOCHGOPH = 1514f;
			}
			KEMJNOMIPHN().SetFloat("_TimeX", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("#tryagain", OnOff);
			EOCCJGIGEGJ().SetFloat("other.dust2", Greenness);
			IFMAPIDFNLI().SetFloat("_LayerThickness", Vignette);
			MLMKCOINOOH().SetFloat("restrictions\n\n#until: ", Vignette_Alpha);
			DKNJGHFLAIF().SetFloat("USE_PREDICATION", Distortion);
			NBPKMLMCHFN.SetFloat("[PlayerBase] ShowTitle error: ", Noise);
			IONHGBPGCHK().SetFloat("SetSatelliteTrailMinVertexDistance", Intensity);
			HKGAONMOBMH().SetFloat("ItemTemplate", Light);
			KEMJNOMIPHN().SetFloat("y", Light2);
			IFMAPIDFNLI().SetFloat("_MinVelocity", Line);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Color_R);
			MLMKCOINOOH().SetFloat("_Offsets", Color_G);
			IONHGBPGCHK().SetFloat("CameraFilterPack/TV_Vcr", Color_B);
			DOHGBNPMBKG().SetFloat("LevelURLInputField", _Binocular_Size);
			DEFBJOCJJKF().SetFloat("Coroutine container not configured... did you forget to call Init?", _Binocular_Dist);
			MICHFGAOPKM().SetFloat("CameraFilterPack/Pixel_Pixelisation", _Binocular_Smooth);
			IFMAPIDFNLI().SetVector("Fade", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1029f)
			{
				HBJJOCHGOPH = 689f;
			}
			GJHLADDCMFF().SetFloat("_Value5", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("st", OnOff);
			OIMMPLPBLBK().SetFloat("GridDataArcs", Greenness);
			MLMKCOINOOH().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", Vignette);
			NBPKMLMCHFN.SetFloat("action", Vignette_Alpha);
			KEMJNOMIPHN().SetFloat("menu.enableselectormusic", Distortion);
			DEFBJOCJJKF().SetFloat("_Value", Noise);
			HKGAONMOBMH().SetFloat("OperationResponse unhandled: {0}", Intensity);
			DOHGBNPMBKG().SetFloat("_MainTex2", Light);
			OIMMPLPBLBK().SetFloat("_TimeX", Light2);
			LENEJAGLCNL().SetFloat("Warning: Unhandled event ", Line);
			OIMMPLPBLBK().SetFloat(" ", Color_R);
			HKGAONMOBMH().SetFloat("OxOD.lastPath", Color_G);
			LENEJAGLCNL().SetFloat("#status", Color_B);
			GJHLADDCMFF().SetFloat("Horizontal", _Binocular_Size);
			HKGAONMOBMH().SetFloat("GameModeText", _Binocular_Dist);
			HKGAONMOBMH().SetFloat("CameraFilterPack_TV_BrokenGlass_2", _Binocular_Smooth);
			MICHFGAOPKM().SetVector("There is already a virtual axis named ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1569f)
			{
				HBJJOCHGOPH = 1226f;
			}
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Distortion_Lens", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("Player Connected", OnOff);
			OIMMPLPBLBK().SetFloat("challenges", Greenness);
			DOHGBNPMBKG().SetFloat("note.1", Vignette);
			DOHGBNPMBKG().SetFloat("#md5submitionfailed: ", Vignette_Alpha);
			KBOPGONOCNP().SetFloat("FrostCanvas", Distortion);
			MCDGIILBNIF().SetFloat("player.bluelifering", Noise);
			IFMAPIDFNLI().SetFloat("x", Intensity);
			KEMJNOMIPHN().SetFloat("CameraFilterPack_Glasses_On5", Light);
			DEFBJOCJJKF().SetFloat("_Parameter", Light2);
			LENEJAGLCNL().SetFloat("Editor/", Line);
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", Color_R);
			IFMAPIDFNLI().SetFloat("Drop_Far", Color_G);
			OIMMPLPBLBK().SetFloat("_TimeX", Color_B);
			EOCCJGIGEGJ().SetFloat("_TimeX", _Binocular_Size);
			IFMAPIDFNLI().SetFloat("ComboScoreText", _Binocular_Dist);
			MLMKCOINOOH().SetFloat("[PlayerBase] SpawnObj error: ", _Binocular_Smooth);
			HKGAONMOBMH().SetVector("RecieveChatActionMessage", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void APKNAPHOFHC()
	{
		if (HODDOPANHAO != Preset)
		{
			HODDOPANHAO = Preset;
			float[] array = new float[36];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array2 = array;
			float[] array3 = new float[-11];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array4 = array3;
			float[] array5 = new float[-60];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array6 = array5;
			float[] array7 = new float[93];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array8 = array7;
			float[] array9 = new float[122];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array10 = array9;
			float[] array11 = new float[4] { 0.2f, 0.159f, 0.622f, -2.28f };
			float[] array12 = new float[124];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array13 = array12;
			float[] array14 = new float[-79];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array15 = array14;
			float[] array16 = new float[-94];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array17 = array16;
			float[] array18 = new float[63];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			float[] array19 = array18;
			float[] array20 = new float[-66];
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (Preset == preset.Night_Vision_FX)
			{
				array20 = array4;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array20 = array6;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array8;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array10;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array20 = array11;
			}
			if (Preset == preset.Night_Vision_Sharp)
			{
				array20 = array13;
			}
			if (Preset == preset.Night_Vision_RedBurn)
			{
				array20 = array15;
			}
			if (Preset == preset.Night_Vision_BlueSky)
			{
				array20 = array17;
			}
			if (Preset == (preset)85)
			{
				array20 = array19;
			}
			if (Preset != preset.Night_Vision_Personalized)
			{
				Greenness = array20[0];
				Vignette = array20[1];
				Vignette_Alpha = array20[7];
				Distortion = array20[2];
				Noise = array20[0];
				Intensity = array20[7];
				Light = array20[0];
				Light2 = array20[5];
				Line = array20[8];
				Color_R = array20[-90];
				Color_G = array20[48];
				Color_B = array20[-26];
			}
		}
	}
}
