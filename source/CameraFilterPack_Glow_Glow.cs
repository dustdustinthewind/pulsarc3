// CameraFilterPack_Glow_Glow
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glow/Glow")]
public class CameraFilterPack_Glow_Glow : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	public float Amount = 4f;

	[Range(2f, 16f)]
	public int FastFilter = 4;

	[Range(0f, 1f)]
	public float Threshold = 0.5f;

	[Range(0f, 1f)]
	public float Intensity = 0.75f;

	[Range(-1f, 1f)]
	public float Precision = 0.56f;

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

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1937f)
			{
				HBJJOCHGOPH = 1121f;
			}
			GKILCDHJFEG().SetFloat("SpectatingUserInfo", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("[LocalizationService] All keys for ", Amount);
			NBMPPNFKFLB().SetFloat("Save the map before exiting?", Threshold);
			DEFBJOCJJKF().SetFloat("Done!", Intensity);
			HEHKGPKLAKK().SetFloat("_HalfResolution", Precision);
			KAFBNOBOIAJ().SetVector("file://", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, GKILCDHJFEG(), 5);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 8);
				Graphics.Blit(temporary2, temporary, DEFBJOCJJKF(), 1);
				GKILCDHJFEG().SetFloat("_SoftZDistance", Amount * 188f);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 1);
				Graphics.Blit(temporary2, temporary, HKGAONMOBMH(), 1);
				IGIAPKPKGPK().SetTexture(" - PUBLISHED #", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 0);
			}
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
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1564f)
			{
				HBJJOCHGOPH = 647f;
			}
			GKILCDHJFEG().SetFloat("_Value5", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("FPSToggle", Amount);
			NBMPPNFKFLB().SetFloat("shader.invert", Threshold);
			IGIAPKPKGPK().SetFloat("_CurrentMipLevel", Intensity);
			NBMPPNFKFLB().SetFloat("/", Precision);
			DEFBJOCJJKF().SetVector(" respawn in future: ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, HEHKGPKLAKK(), 7);
				Graphics.Blit(temporary, temporary2, IGIAPKPKGPK(), 4);
				Graphics.Blit(temporary2, temporary, DEFBJOCJJKF(), 0);
				PGPEMMBJOOG().SetFloat("#availablechallenges", Amount * 29f);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 5);
				Graphics.Blit(temporary2, temporary, IGIAPKPKGPK(), 1);
				NBPKMLMCHFN.SetTexture("CameraFilterPack_Glasses_On7", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 794f)
			{
				HBJJOCHGOPH = 1255f;
			}
			PGPEMMBJOOG().SetFloat("D-Pad Up", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("SetSpeed", Amount);
			PGPEMMBJOOG().SetFloat("_TimeX", Threshold);
			NBPKMLMCHFN.SetFloat("\\n", Intensity);
			FLOHGDECHHH().SetFloat("Joystick1Button", Precision);
			KAFBNOBOIAJ().SetVector("Lag ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, PGPEMMBJOOG(), 0);
				Graphics.Blit(temporary, temporary2, HEHKGPKLAKK(), 7);
				Graphics.Blit(temporary2, temporary, HEHKGPKLAKK(), 1);
				NBPKMLMCHFN.SetFloat("_Value5", Amount * 928f);
				Graphics.Blit(temporary, temporary2, IGIAPKPKGPK(), 2);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 1);
				PGPEMMBJOOG().SetTexture("settings.hitvariation", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1429f)
			{
				HBJJOCHGOPH = 822f;
			}
			IGIAPKPKGPK().SetFloat("LevelNameInputField", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("Xbox Home", Amount);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/Lut_PlayWith", Threshold);
			PGPEMMBJOOG().SetFloat("SetRoomStartTimestamp", Intensity);
			NBPKMLMCHFN.SetFloat(" not exist", Precision);
			GKILCDHJFEG().SetVector("DPADHOR", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, KAFBNOBOIAJ(), 8);
				Graphics.Blit(temporary, temporary2, NBMPPNFKFLB(), 5);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				IGIAPKPKGPK().SetFloat("_Size", Amount * 469f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 8);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 1);
				NBMPPNFKFLB().SetTexture("_TimeX", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 0);
			}
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
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 636f)
			{
				HBJJOCHGOPH = 801f;
			}
			PGPEMMBJOOG().SetFloat("[MapsStats] Map ID: ", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("_Offsets", Amount);
			PGPEMMBJOOG().SetFloat(",0", Threshold);
			PGPEMMBJOOG().SetFloat("masterSteamID", Intensity);
			GKILCDHJFEG().SetFloat("Yes", Precision);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, FLOHGDECHHH(), 5);
				Graphics.Blit(temporary, temporary2, DEFBJOCJJKF(), 2);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 0);
				IGIAPKPKGPK().SetFloat("OK", Amount * 1894f);
				Graphics.Blit(temporary, temporary2, NBMPPNFKFLB(), 1);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 0);
				DEFBJOCJJKF().SetTexture("\n\n#", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_NoiseTilingPerChannel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1387f)
			{
				HBJJOCHGOPH = 692f;
			}
			DEFBJOCJJKF().SetFloat("[PlayerBase] Loaded custom model: ", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("Trackpad", Amount);
			PGPEMMBJOOG().SetFloat("[MenuScene] Error: ", Threshold);
			GKILCDHJFEG().SetFloat("settings.enableselectormusic", Intensity);
			NBMPPNFKFLB().SetFloat("Reload Maps", Precision);
			HKGAONMOBMH().SetVector("Done!", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, NBMPPNFKFLB(), 1);
				Graphics.Blit(temporary, temporary2, HEHKGPKLAKK(), 5);
				Graphics.Blit(temporary2, temporary, NBMPPNFKFLB(), 1);
				NBMPPNFKFLB().SetFloat("_Value", Amount * 208f);
				Graphics.Blit(temporary, temporary2, IGIAPKPKGPK(), 1);
				Graphics.Blit(temporary2, temporary, HEHKGPKLAKK(), 0);
				PGPEMMBJOOG().SetTexture("_ScreenResolution", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 0);
			}
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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1275f)
			{
				HBJJOCHGOPH = 1888f;
			}
			DEFBJOCJJKF().SetFloat("_Value", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("key", Amount);
			FLOHGDECHHH().SetFloat("{0}_{1}", Threshold);
			GKILCDHJFEG().SetFloat("GameScene", Intensity);
			IGIAPKPKGPK().SetFloat("Scene", Precision);
			DEFBJOCJJKF().SetVector("player.linea", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, NBMPPNFKFLB(), 7);
				Graphics.Blit(temporary, temporary2, IGIAPKPKGPK(), 6);
				Graphics.Blit(temporary2, temporary, DEFBJOCJJKF(), 1);
				PGPEMMBJOOG().SetFloat("_Red_C", Amount * 1527f);
				Graphics.Blit(temporary, temporary2, NBMPPNFKFLB(), 6);
				Graphics.Blit(temporary2, temporary, IGIAPKPKGPK(), 1);
				PGPEMMBJOOG().SetTexture("CameraFilterPack/Real_VHS", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 938f)
			{
				HBJJOCHGOPH = 1536f;
			}
			GKILCDHJFEG().SetFloat("_Red_R", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("MultiplayerButton", Amount);
			DEFBJOCJJKF().SetFloat("#forever", Threshold);
			PGPEMMBJOOG().SetFloat("0,1,false", Intensity);
			GKILCDHJFEG().SetFloat("\n\n#", Precision);
			FLOHGDECHHH().SetVector("End Value should be greater than the start value, values not changed", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, IGIAPKPKGPK(), 7);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 8);
				Graphics.Blit(temporary2, temporary, DEFBJOCJJKF(), 0);
				GKILCDHJFEG().SetFloat("_Radius", Amount * 1459f);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 1);
				Graphics.Blit(temporary2, temporary, KAFBNOBOIAJ(), 0);
				DEFBJOCJJKF().SetTexture("Case-Sensitive", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1801f)
			{
				HBJJOCHGOPH = 776f;
			}
			NBPKMLMCHFN.SetFloat("/Segment-[Right]", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("RoomDescriptionText", Amount);
			NBMPPNFKFLB().SetFloat("menu.selectedplaymode", Threshold);
			KAFBNOBOIAJ().SetFloat("\\\\", Intensity);
			IGIAPKPKGPK().SetFloat("CameraFilterPack/AAA_Blood", Precision);
			FLOHGDECHHH().SetVector("_Blend", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, PGPEMMBJOOG(), 2);
				Graphics.Blit(temporary, temporary2, KAFBNOBOIAJ(), 0);
				Graphics.Blit(temporary2, temporary, HKGAONMOBMH(), 0);
				KAFBNOBOIAJ().SetFloat("bpmgrid", Amount * 1792f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, HEHKGPKLAKK(), 1);
				DEFBJOCJJKF().SetTexture("st", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1258f)
			{
				HBJJOCHGOPH = 1618f;
			}
			DEFBJOCJJKF().SetFloat("_Params1", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_Parameter", Amount);
			HEHKGPKLAKK().SetFloat("NewMusicFileSelector", Threshold);
			NBMPPNFKFLB().SetFloat("_TimeX", Intensity);
			PGPEMMBJOOG().SetFloat("_Value5", Precision);
			NBMPPNFKFLB().SetVector("CameraFilterPack/Drawing_Manga_FlashWhite", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, NBMPPNFKFLB(), 2);
				Graphics.Blit(temporary, temporary2, HEHKGPKLAKK(), 7);
				Graphics.Blit(temporary2, temporary, GKILCDHJFEG(), 0);
				KAFBNOBOIAJ().SetFloat("Change Note:", Amount * 279f);
				Graphics.Blit(temporary, temporary2, IGIAPKPKGPK(), 5);
				Graphics.Blit(temporary2, temporary, GKILCDHJFEG(), 1);
				PGPEMMBJOOG().SetTexture("/", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 683f)
			{
				HBJJOCHGOPH = 1416f;
			}
			HEHKGPKLAKK().SetFloat("View ({3}){0} on {1} {2}", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("YES", Amount);
			NBMPPNFKFLB().SetFloat(" Maybe GO was destroyed but RPC not cleaned up.", Threshold);
			HKGAONMOBMH().SetFloat("value", Intensity);
			HEHKGPKLAKK().SetFloat("[ResourcesManager] Load text error: not found", Precision);
			FLOHGDECHHH().SetVector("_FarCamera", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, KAFBNOBOIAJ(), 4);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 5);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				NBMPPNFKFLB().SetFloat("</color>", Amount * 1637f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				FLOHGDECHHH().SetTexture("Write me to get one for testing :)", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Glow_Glow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("DifficultyBG");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 812f)
			{
				HBJJOCHGOPH = 269f;
			}
			NBMPPNFKFLB().SetFloat("_U", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SaveButton", Amount);
			FLOHGDECHHH().SetFloat("MessageText", Threshold);
			PGPEMMBJOOG().SetFloat("_Offsets", Intensity);
			HKGAONMOBMH().SetFloat("workshop.", Precision);
			NBPKMLMCHFN.SetVector("_Value", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, IGIAPKPKGPK(), 1);
				Graphics.Blit(temporary, temporary2, HKGAONMOBMH(), 3);
				Graphics.Blit(temporary2, temporary, KAFBNOBOIAJ(), 0);
				NBPKMLMCHFN.SetFloat("_DotSize", Amount * 1494f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, GKILCDHJFEG(), 0);
				PGPEMMBJOOG().SetTexture(".mp3", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Amount", Amount);
			NBPKMLMCHFN.SetFloat("_Value1", Threshold);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", Precision);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("_Amount", Amount * 2f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetTexture("_MainTex2", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LLJLDLLNFBH()
	{
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1735f)
			{
				HBJJOCHGOPH = 658f;
			}
			DEFBJOCJJKF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_Far", Amount);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Color_Sepia", Threshold);
			NBPKMLMCHFN.SetFloat("Classical", Intensity);
			KAFBNOBOIAJ().SetFloat("music.ogg", Precision);
			DEFBJOCJJKF().SetVector("_TimeX", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, IGIAPKPKGPK(), 6);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 2);
				Graphics.Blit(temporary2, temporary, NBMPPNFKFLB(), 0);
				PGPEMMBJOOG().SetFloat("CameraFilterPack/Vision_Plasma", Amount * 617f);
				Graphics.Blit(temporary, temporary2, HKGAONMOBMH(), 7);
				Graphics.Blit(temporary2, temporary, GKILCDHJFEG(), 0);
				KAFBNOBOIAJ().SetTexture("_Bloom", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1384f)
			{
				HBJJOCHGOPH = 476f;
			}
			PGPEMMBJOOG().SetFloat("_ChangeBlue", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("Sending RPC \"", Amount);
			GKILCDHJFEG().SetFloat("_Value2", Threshold);
			FLOHGDECHHH().SetFloat("_Cible", Intensity);
			IGIAPKPKGPK().SetFloat("AvatarImage", Precision);
			PGPEMMBJOOG().SetVector("CameraFilterPack/FX_Dot_Circle", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, GKILCDHJFEG(), 6);
				Graphics.Blit(temporary, temporary2, DEFBJOCJJKF(), 4);
				Graphics.Blit(temporary2, temporary, IGIAPKPKGPK(), 1);
				FLOHGDECHHH().SetFloat("_TimeX", Amount * 1004f);
				Graphics.Blit(temporary, temporary2, FLOHGDECHHH(), 1);
				Graphics.Blit(temporary2, temporary, HKGAONMOBMH(), 0);
				HEHKGPKLAKK().SetTexture("CameraFilterPack/Gradients_Rainbow", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_InvViewProj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("hand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}
}
