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
			EOCCJGIGEGJ().SetFloat("<b>#banended</b>", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("finished", OnOff);
			IFMAPIDFNLI().SetFloat("Set satellite audio input", Greenness);
			DOHGBNPMBKG().SetFloat("/theme", Vignette);
			IFMAPIDFNLI().SetFloat("PLEASE WAIT", Vignette_Alpha);
			NBPKMLMCHFN.SetFloat("_Smooth", Distortion);
			EOCCJGIGEGJ().SetFloat(" on effect ", Noise);
			LENEJAGLCNL().SetFloat("Horizontal", Intensity);
			NBPKMLMCHFN.SetFloat("BadgeText", Light);
			MLMKCOINOOH().SetFloat("Overlay", Light2);
			EOCCJGIGEGJ().SetFloat("\\", Line);
			MLMKCOINOOH().SetFloat("InfoCanvas", Color_R);
			IONHGBPGCHK().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Color_G);
			LENEJAGLCNL().SetFloat("LevelConfigButton", Color_B);
			DEFBJOCJJKF().SetFloat("LevelInfoInputField", _Binocular_Size);
			KEMJNOMIPHN().SetFloat("id", _Binocular_Dist);
			EOCCJGIGEGJ().SetFloat("file://", _Binocular_Smooth);
			DEFBJOCJJKF().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("CameraFilterPack/Pixelisation_OilPaint");
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
		SCShader = Shader.Find("_Blue_C");
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
		SCShader = Shader.Find("tagElement");
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
			MICHFGAOPKM().SetFloat("bool", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("/icon", OnOff);
			GJHLADDCMFF().SetFloat("LastNewsButton", Greenness);
			KBOPGONOCNP().SetFloat("_Line", Vignette);
			EOCCJGIGEGJ().SetFloat("#E14FFF", Vignette_Alpha);
			GJHLADDCMFF().SetFloat(" ", Distortion);
			MICHFGAOPKM().SetFloat(".lastCheckpoint.comboScore", Noise);
			DEFBJOCJJKF().SetFloat("st", Intensity);
			OIMMPLPBLBK().SetFloat("colorB", Light);
			DEFBJOCJJKF().SetFloat("mapselector.tags.", Light2);
			IONHGBPGCHK().SetFloat("Clears all text from the debug console", Line);
			MCDGIILBNIF().SetFloat("SpectatingUserInfo", Color_R);
			KBOPGONOCNP().SetFloat("SetLives", Color_G);
			DOHGBNPMBKG().SetFloat("_TimeX", Color_B);
			KBOPGONOCNP().SetFloat("#rt", _Binocular_Size);
			KEMJNOMIPHN().SetFloat("[MapsSystem] Unloading maps resources...", _Binocular_Dist);
			NBPKMLMCHFN.SetFloat("[GameScene] Submiting rank", _Binocular_Smooth);
			DOHGBNPMBKG().SetVector(".", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			LENEJAGLCNL().SetFloat("_Value3", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("closed", OnOff);
			KBOPGONOCNP().SetFloat("_CenterX", Greenness);
			DKNJGHFLAIF().SetFloat("LobbyCanvas", Vignette);
			MICHFGAOPKM().SetFloat("_ScreenResolution", Vignette_Alpha);
			KEMJNOMIPHN().SetFloat("_FarCamera", Distortion);
			KEMJNOMIPHN().SetFloat("Bad parameters for getbool! Use <key> <value>", Noise);
			MLMKCOINOOH().SetFloat("SetSunSensitivity", Intensity);
			DOHGBNPMBKG().SetFloat("PUNCloudBestRegion", Light);
			MLMKCOINOOH().SetFloat("mapselector.lastSearch", Light2);
			MICHFGAOPKM().SetFloat(": ", Line);
			HKGAONMOBMH().SetFloat("SetSpeed", Color_R);
			NBPKMLMCHFN.SetFloat("st", Color_G);
			MLMKCOINOOH().SetFloat("Rotate environment object to the rotation", Color_B);
			DOHGBNPMBKG().SetFloat("JoinButton", _Binocular_Size);
			KBOPGONOCNP().SetFloat("_Offsets", _Binocular_Dist);
			KBOPGONOCNP().SetFloat("a month ago", _Binocular_Smooth);
			IONHGBPGCHK().SetVector("/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			NBPKMLMCHFN.SetFloat("FileMenu", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("Missing shader in ", OnOff);
			MLMKCOINOOH().SetFloat("_Light2", Greenness);
			NBPKMLMCHFN.SetFloat("(master)", Vignette);
			GJHLADDCMFF().SetFloat("Operation failed: ", Vignette_Alpha);
			DEFBJOCJJKF().SetFloat(",", Distortion);
			MCDGIILBNIF().SetFloat("\n", Noise);
			HKGAONMOBMH().SetFloat("<command>", Intensity);
			MLMKCOINOOH().SetFloat("_ScreenResolution", Light);
			OIMMPLPBLBK().SetFloat("FinalScoreText", Light2);
			LENEJAGLCNL().SetFloat("Tab1Content", Line);
			LENEJAGLCNL().SetFloat("PublishButton", Color_R);
			HKGAONMOBMH().SetFloat("Texture2", Color_G);
			GJHLADDCMFF().SetFloat("menu.selectedplaymode", Color_B);
			KBOPGONOCNP().SetFloat("hidden", _Binocular_Size);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", _Binocular_Dist);
			IFMAPIDFNLI().SetFloat("_Value8", _Binocular_Smooth);
			DKNJGHFLAIF().SetVector("/?player=", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
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
			EOCCJGIGEGJ().SetFloat("Lerp speed. Recomended 10", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("mapselector.filter.subscribedonly", OnOff);
			MCDGIILBNIF().SetFloat("z", Greenness);
			KEMJNOMIPHN().SetFloat("SupportLogger Info: PUN {0}: ", Vignette);
			KEMJNOMIPHN().SetFloat("logc", Vignette_Alpha);
			IONHGBPGCHK().SetFloat("ResetButton", Distortion);
			DOHGBNPMBKG().SetFloat("_FgOverlap", Noise);
			OIMMPLPBLBK().SetFloat("Creating new item...", Intensity);
			KEMJNOMIPHN().SetFloat("' has been reset to the fault value", Light);
			MICHFGAOPKM().SetFloat("PossibleMapPointsText", Light2);
			KEMJNOMIPHN().SetFloat("settings.volume.menu", Line);
			HKGAONMOBMH().SetFloat("In Main Menu", Color_R);
			IFMAPIDFNLI().SetFloat("Save", Color_G);
			NBPKMLMCHFN.SetFloat("0 - default, 1 - left, 2 - right", Color_B);
			EOCCJGIGEGJ().SetFloat("id", _Binocular_Size);
			MCDGIILBNIF().SetFloat("CameraFilterPack/FX_Ascii", _Binocular_Dist);
			DOHGBNPMBKG().SetFloat("NameText", _Binocular_Smooth);
			DKNJGHFLAIF().SetVector("0,7,true,0", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		SCShader = Shader.Find("value");
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
		SCShader = Shader.Find("Joystick1Button4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("_InvScreenSize");
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
			GJHLADDCMFF().SetFloat("_MainTex2", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("LoadingStatusText", OnOff);
			MLMKCOINOOH().SetFloat("Have you fully accept the terms?", Greenness);
			DKNJGHFLAIF().SetFloat("_Value7", Vignette);
			HKGAONMOBMH().SetFloat("_SphereSize", Vignette_Alpha);
			DOHGBNPMBKG().SetFloat("_BlurSize", Distortion);
			LENEJAGLCNL().SetFloat("CreateRoom failed. In offline mode you still have to leave a room to enter another.", Noise);
			LENEJAGLCNL().SetFloat("#{0:00}{1}{2}", Intensity);
			DKNJGHFLAIF().SetFloat("inventory.selected.", Light);
			DEFBJOCJJKF().SetFloat("Prints list of commands", Light2);
			MICHFGAOPKM().SetFloat("_TimeX", Line);
			MCDGIILBNIF().SetFloat("PopulateMapsList", Color_R);
			HKGAONMOBMH().SetFloat("_Value", Color_G);
			OIMMPLPBLBK().SetFloat("Pop", Color_B);
			IONHGBPGCHK().SetFloat("OnPickedUp", _Binocular_Size);
			OIMMPLPBLBK().SetFloat("/", _Binocular_Dist);
			IFMAPIDFNLI().SetFloat("\n", _Binocular_Smooth);
			MLMKCOINOOH().SetVector("settings_bindings_controller_type", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			HKGAONMOBMH().SetFloat("player.redabstract", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("DPADHOR", OnOff);
			DEFBJOCJJKF().SetFloat("_Value", Greenness);
			EOCCJGIGEGJ().SetFloat("_Value", Vignette);
			KBOPGONOCNP().SetFloat("ViewMenu", Vignette_Alpha);
			LENEJAGLCNL().SetFloat("AudioSampler", Distortion);
			MICHFGAOPKM().SetFloat("PlayButton", Noise);
			DOHGBNPMBKG().SetFloat("Exception caught! ", Intensity);
			MICHFGAOPKM().SetFloat(" with a prefix of ", Light);
			MLMKCOINOOH().SetFloat("error", Light2);
			DOHGBNPMBKG().SetFloat("USE_UV_BASED_REPROJECTION", Line);
			EOCCJGIGEGJ().SetFloat("BitsData", Color_R);
			LENEJAGLCNL().SetFloat("CameraFilterPack/Drawing_Toon", Color_G);
			DEFBJOCJJKF().SetFloat("ShadersToggle", Color_B);
			IFMAPIDFNLI().SetFloat("Tab2Content", _Binocular_Size);
			DEFBJOCJJKF().SetFloat("...", _Binocular_Dist);
			MICHFGAOPKM().SetFloat("BitsData", _Binocular_Smooth);
			OIMMPLPBLBK().SetVector("_Red_R", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
		SCShader = Shader.Find("settings.volume.menu");
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
		SCShader = Shader.Find("_color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("[LevelEditorScene] Updated");
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
		SCShader = Shader.Find("float,0");
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
		SCShader = Shader.Find("menu.selectedplaymode");
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
			OIMMPLPBLBK().SetFloat(": ", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("SpawnObj", OnOff);
			DOHGBNPMBKG().SetFloat("1", Greenness);
			MCDGIILBNIF().SetFloat("CameraFilterPack/EyesVision_1", Vignette);
			DEFBJOCJJKF().SetFloat("0,7,true,0", Vignette_Alpha);
			IONHGBPGCHK().SetFloat("intensity", Distortion);
			LENEJAGLCNL().SetFloat("R2", Noise);
			NBPKMLMCHFN.SetFloat(": ", Intensity);
			MCDGIILBNIF().SetFloat(": ", Light);
			MCDGIILBNIF().SetFloat("_Fade", Light2);
			MCDGIILBNIF().SetFloat("EnvironmentSlider", Line);
			EOCCJGIGEGJ().SetFloat("[PlayerController] ", Color_R);
			IONHGBPGCHK().SetFloat("settings_bindings_controller_type", Color_G);
			HKGAONMOBMH().SetFloat("_TimeX", Color_B);
			IONHGBPGCHK().SetFloat(" x ", _Binocular_Size);
			OIMMPLPBLBK().SetFloat("ConnectToRegion: ", _Binocular_Dist);
			GJHLADDCMFF().SetFloat("Texture2", _Binocular_Smooth);
			KEMJNOMIPHN().SetVector("mapselector.tags.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("_CameraClipInfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("SpectatingUserInfo");
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
			EOCCJGIGEGJ().SetFloat("_VignettingDirt", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("maps.", OnOff);
			KBOPGONOCNP().SetFloat("#,0", Greenness);
			LENEJAGLCNL().SetFloat("_PositionX", Vignette);
			EOCCJGIGEGJ().SetFloat(" scene: ", Vignette_Alpha);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/Edge_BlackLine", Distortion);
			NBPKMLMCHFN.SetFloat("ItemNameBGImage", Noise);
			DKNJGHFLAIF().SetFloat("_Value3", Intensity);
			HKGAONMOBMH().SetFloat("Move environment object to the position", Light);
			GJHLADDCMFF().SetFloat("_Value2", Light2);
			IONHGBPGCHK().SetFloat("player.slash", Line);
			MLMKCOINOOH().SetFloat("Lerp speed. Recomended 10", Color_R);
			MICHFGAOPKM().SetFloat("StartCanvas", Color_G);
			IONHGBPGCHK().SetFloat("_ScratchOffsetScale", Color_B);
			LENEJAGLCNL().SetFloat("/", _Binocular_Size);
			OIMMPLPBLBK().SetFloat("Could not find RPC with index: ", _Binocular_Dist);
			MCDGIILBNIF().SetFloat("(\\[ */ *b *\\])", _Binocular_Smooth);
			OIMMPLPBLBK().SetVector("/Segment-[Right]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("set environment id");
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
			DEFBJOCJJKF().SetFloat("visible", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("Joystick1Button5", OnOff);
			IONHGBPGCHK().SetFloat("_ColorKey", Greenness);
			KEMJNOMIPHN().SetFloat("<i>", Vignette);
			DKNJGHFLAIF().SetFloat("CameraFilterPack_RainFX_Anm2", Vignette_Alpha);
			IFMAPIDFNLI().SetFloat(" not exist", Distortion);
			LENEJAGLCNL().SetFloat("sounds/hit_perfect", Noise);
			GJHLADDCMFF().SetFloat("There is already a virtual button named ", Intensity);
			EOCCJGIGEGJ().SetFloat("an hour ago", Light);
			NBPKMLMCHFN.SetFloat("[MapsData] Found ", Light2);
			HKGAONMOBMH().SetFloat("BadgeImage", Line);
			KEMJNOMIPHN().SetFloat("_Offsets", Color_R);
			IFMAPIDFNLI().SetFloat("_Value4", Color_G);
			MLMKCOINOOH().SetFloat("BadgeText", Color_B);
			EOCCJGIGEGJ().SetFloat("Set Satellite Trail Length", _Binocular_Size);
			DEFBJOCJJKF().SetFloat("GlassDistortion", _Binocular_Dist);
			MCDGIILBNIF().SetFloat("_Intensity", _Binocular_Smooth);
			KBOPGONOCNP().SetVector("Set Sun Sensitivity", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("d264dbba9c2410771b4ad918903b3f4cd9e276a9");
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
			MLMKCOINOOH().SetFloat("SupportLogger Info: PUN {0}: ", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_Size", OnOff);
			KBOPGONOCNP().SetFloat("ScrollPanel", Greenness);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", Vignette);
			DOHGBNPMBKG().SetFloat("steamid", Vignette_Alpha);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Distortion);
			LENEJAGLCNL().SetFloat("Set environment sprite color and alpha.", Noise);
			MLMKCOINOOH().SetFloat("_DistortionLevel", Intensity);
			HKGAONMOBMH().SetFloat("IconFileSelector", Light);
			DOHGBNPMBKG().SetFloat("#pleasewait", Light2);
			MICHFGAOPKM().SetFloat("InventoryGrid", Line);
			KBOPGONOCNP().SetFloat("_TimeX", Color_R);
			OIMMPLPBLBK().SetFloat(" not exist", Color_G);
			IONHGBPGCHK().SetFloat("_FarCamera", Color_B);
			IFMAPIDFNLI().SetFloat("_InvViewProj", _Binocular_Size);
			OIMMPLPBLBK().SetFloat(".played", _Binocular_Dist);
			KBOPGONOCNP().SetFloat("[LevelEditorScene] Print Audio Wave: Start", _Binocular_Smooth);
			MLMKCOINOOH().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
			IONHGBPGCHK().SetFloat(" to: ", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat(" isInactive: ", OnOff);
			MICHFGAOPKM().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Greenness);
			DEFBJOCJJKF().SetFloat("Myst", Vignette);
			MICHFGAOPKM().SetFloat(" / ", Vignette_Alpha);
			OIMMPLPBLBK().SetFloat("Skipping EstablishEncryption. Protocol is secure.", Distortion);
			DEFBJOCJJKF().SetFloat("_Distortion", Noise);
			MICHFGAOPKM().SetFloat("float,0", Intensity);
			HKGAONMOBMH().SetFloat("settings.gamemessagesduration", Light);
			DOHGBNPMBKG().SetFloat("_Value3", Light2);
			DKNJGHFLAIF().SetFloat(".completed", Line);
			MICHFGAOPKM().SetFloat("#tryagain", Color_R);
			IONHGBPGCHK().SetFloat("Screenshots only supported in PlayMode", Color_G);
			LENEJAGLCNL().SetFloat("deleteall", Color_B);
			LENEJAGLCNL().SetFloat("FullscreenToggle", _Binocular_Size);
			LENEJAGLCNL().SetFloat("[MapsData] Bad map: ", _Binocular_Dist);
			DEFBJOCJJKF().SetFloat("_TimeX", _Binocular_Smooth);
			DEFBJOCJJKF().SetVector("PossibleMapPointsText", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("_Value4");
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
			DEFBJOCJJKF().SetFloat("/?player=", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Aug", OnOff);
			IFMAPIDFNLI().SetFloat("menu.selectedplaymode", Greenness);
			KBOPGONOCNP().SetFloat("mapselector.filter.favoriteonly", Vignette);
			DKNJGHFLAIF().SetFloat("_InternalLutParams", Vignette_Alpha);
			MLMKCOINOOH().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Distortion);
			DEFBJOCJJKF().SetFloat("ViewMenu", Noise);
			OIMMPLPBLBK().SetFloat(" : ", Intensity);
			DKNJGHFLAIF().SetFloat("CloseConnection: Only the masterclient can kick another player.", Light);
			DEFBJOCJJKF().SetFloat("SelectorMusicToggle", Light2);
			MLMKCOINOOH().SetFloat("DPADHOR", Line);
			HKGAONMOBMH().SetFloat("BadgeText", Color_R);
			IFMAPIDFNLI().SetFloat(" cannot be used as a 3D LUT.", Color_G);
			HKGAONMOBMH().SetFloat("Editor/", Color_B);
			LENEJAGLCNL().SetFloat(".lastCheckpoint.correctScore", _Binocular_Size);
			MICHFGAOPKM().SetFloat("event", _Binocular_Dist);
			IFMAPIDFNLI().SetFloat("CameraFilterPack/Drawing_Toon", _Binocular_Smooth);
			HKGAONMOBMH().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
		SCShader = Shader.Find("_MainTex2");
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
			EOCCJGIGEGJ().SetFloat("Map: ", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_TimeX", OnOff);
			KEMJNOMIPHN().SetFloat("gold", Greenness);
			GJHLADDCMFF().SetFloat("_ScreenResolution", Vignette);
			EOCCJGIGEGJ().SetFloat("_TimeX", Vignette_Alpha);
			DKNJGHFLAIF().SetFloat("_DepthLevel", Distortion);
			MICHFGAOPKM().SetFloat("_Threshold", Noise);
			IONHGBPGCHK().SetFloat("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.", Intensity);
			HKGAONMOBMH().SetFloat("_MainTex2", Light);
			MCDGIILBNIF().SetFloat("_MainTex2", Light2);
			KBOPGONOCNP().SetFloat(" is muted", Line);
			GJHLADDCMFF().SetFloat("_Value4", Color_R);
			HKGAONMOBMH().SetFloat("_ScreenResolution", Color_G);
			OIMMPLPBLBK().SetFloat("BadgeText", Color_B);
			IONHGBPGCHK().SetFloat("There is already a virtual axis named ", _Binocular_Size);
			KEMJNOMIPHN().SetFloat("_Value2", _Binocular_Dist);
			MICHFGAOPKM().SetFloat("_CurrentMipLevel", _Binocular_Smooth);
			EOCCJGIGEGJ().SetVector("value", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
		SCShader = Shader.Find("_Alpha2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).");
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
			LENEJAGLCNL().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("#ok", OnOff);
			MLMKCOINOOH().SetFloat("other.dust1", Greenness);
			IONHGBPGCHK().SetFloat("_MaxRayTraceDistance", Vignette);
			DOHGBNPMBKG().SetFloat("\n\n#", Vignette_Alpha);
			IFMAPIDFNLI().SetFloat("_ReprojectionMatrix", Distortion);
			DKNJGHFLAIF().SetFloat("[PlayerBase] SetPlayerDistance error: ", Noise);
			LENEJAGLCNL().SetFloat("Set satellite trail width", Intensity);
			MLMKCOINOOH().SetFloat("SlidingArea", Light);
			MLMKCOINOOH().SetFloat("z", Light2);
			KBOPGONOCNP().SetFloat("_MaxRadiusOrKInPaper", Line);
			LENEJAGLCNL().SetFloat("_ScreenResolution", Color_R);
			DKNJGHFLAIF().SetFloat("_Offsets", Color_G);
			DEFBJOCJJKF().SetFloat("Fade", Color_B);
			KEMJNOMIPHN().SetFloat("Tab1Content", _Binocular_Size);
			DKNJGHFLAIF().SetFloat("HighScaleShot", _Binocular_Dist);
			MCDGIILBNIF().SetFloat("_MainTex2", _Binocular_Smooth);
			MLMKCOINOOH().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
			IONHGBPGCHK().SetFloat("_Value5", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("1", OnOff);
			DOHGBNPMBKG().SetFloat("GridDataArcs", Greenness);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Vignette);
			DEFBJOCJJKF().SetFloat("menuVolume", Vignette_Alpha);
			OIMMPLPBLBK().SetFloat("SelectorMusicToggle", Distortion);
			DOHGBNPMBKG().SetFloat("_Value", Noise);
			MCDGIILBNIF().SetFloat("JoinRandom failed: {0}.", Intensity);
			LENEJAGLCNL().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Light);
			MCDGIILBNIF().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", Light2);
			KEMJNOMIPHN().SetFloat(". Sent by actorNr: ", Line);
			DEFBJOCJJKF().SetFloat("Item ", Color_R);
			DOHGBNPMBKG().SetFloat("/../", Color_G);
			MICHFGAOPKM().SetFloat(":</b> ", Color_B);
			MCDGIILBNIF().SetFloat("#rt", _Binocular_Size);
			DKNJGHFLAIF().SetFloat("GameModeText", _Binocular_Dist);
			HKGAONMOBMH().SetFloat("_MainTex2", _Binocular_Smooth);
			EOCCJGIGEGJ().SetVector("Horizontal", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
		SCShader = Shader.Find(".lastCheckpoint.time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("PRESS A KEY");
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
			IONHGBPGCHK().SetFloat("CameraFilterPack/Distortion_Lens", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("Player Connected", OnOff);
			DEFBJOCJJKF().SetFloat("???", Greenness);
			EOCCJGIGEGJ().SetFloat("#outdatedmap! Challenges will not work!", Vignette);
			EOCCJGIGEGJ().SetFloat("bad", Vignette_Alpha);
			GJHLADDCMFF().SetFloat("settings.shaders.bloomintencity", Distortion);
			DOHGBNPMBKG().SetFloat("player.redlifering", Noise);
			HKGAONMOBMH().SetFloat("x", Intensity);
			DEFBJOCJJKF().SetFloat("_MainTex2", Light);
			DKNJGHFLAIF().SetFloat("vignetteIntensity", Light2);
			MICHFGAOPKM().SetFloat("editor.", Line);
			MLMKCOINOOH().SetFloat("_ScreenResolution", Color_R);
			DEFBJOCJJKF().SetFloat("Drop_Far", Color_G);
			MICHFGAOPKM().SetFloat("_TimeX", Color_B);
			OIMMPLPBLBK().SetFloat("_TimeX", _Binocular_Size);
			EOCCJGIGEGJ().SetFloat("IncorrectHitsScoreText", _Binocular_Dist);
			IONHGBPGCHK().SetFloat("[PlayerBase] Unknown event: ", _Binocular_Smooth);
			EOCCJGIGEGJ().SetVector("ChangeSelectedLevel", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		SCShader = Shader.Find("_Value3");
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
