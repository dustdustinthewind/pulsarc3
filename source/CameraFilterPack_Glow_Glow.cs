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
		SCShader = Shader.Find("PopulateMapsList");
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
		SCShader = Shader.Find("_CenterY");
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
			NBPKMLMCHFN.SetFloat("SpectatingUserInfo", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat(" - Contains ", Amount);
			HKGAONMOBMH().SetFloat("YES", Threshold);
			NBMPPNFKFLB().SetFloat("Done!", Intensity);
			HKGAONMOBMH().SetFloat("_MaxSteps", Precision);
			HKGAONMOBMH().SetVector("file://", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, FLOHGDECHHH(), 5);
				Graphics.Blit(temporary, temporary2, FLOHGDECHHH(), 8);
				Graphics.Blit(temporary2, temporary, NBMPPNFKFLB(), 1);
				DEFBJOCJJKF().SetFloat("_SoftZDistance", Amount * 188f);
				Graphics.Blit(temporary, temporary2, HEHKGPKLAKK(), 1);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 1);
				GKILCDHJFEG().SetTexture(" - LOCAL", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK(), 0);
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
			DEFBJOCJJKF().SetFloat("_Value4", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("FPSToggle", Amount);
			IGIAPKPKGPK().SetFloat("shader.none", Threshold);
			HEHKGPKLAKK().SetFloat("Screen Space Reflections", Intensity);
			KAFBNOBOIAJ().SetFloat("#failed!", Precision);
			GKILCDHJFEG().SetVector(" SecondsBeforeRespawn: ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBMPPNFKFLB(), 7);
				Graphics.Blit(temporary, temporary2, FLOHGDECHHH(), 4);
				Graphics.Blit(temporary2, temporary, PGPEMMBJOOG(), 0);
				PGPEMMBJOOG().SetFloat("<b>", Amount * 29f);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 5);
				Graphics.Blit(temporary2, temporary, IGIAPKPKGPK(), 1);
				FLOHGDECHHH().SetTexture("_MainTex2", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH(), 1);
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
			NBPKMLMCHFN.SetFloat("Joystick1Button12", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("/", Amount);
			KAFBNOBOIAJ().SetFloat("_MainTex2", Threshold);
			HKGAONMOBMH().SetFloat("#", Intensity);
			HEHKGPKLAKK().SetFloat("^", Precision);
			GKILCDHJFEG().SetVector("No peer to communicate with. ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, DEFBJOCJJKF(), 0);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 7);
				Graphics.Blit(temporary2, temporary, HKGAONMOBMH(), 1);
				DEFBJOCJJKF().SetFloat("_Value4", Amount * 928f);
				Graphics.Blit(temporary, temporary2, DEFBJOCJJKF(), 2);
				Graphics.Blit(temporary2, temporary, KAFBNOBOIAJ(), 1);
				NBPKMLMCHFN.SetTexture("settings.hitvariation", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH(), 1);
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
			NBPKMLMCHFN.SetFloat("LevelNameInputField", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("Joystick1Button12", Amount);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Threshold);
			HEHKGPKLAKK().SetFloat("turn: {0:0}", Intensity);
			HEHKGPKLAKK().SetFloat(": ", Precision);
			FLOHGDECHHH().SetVector("DPADHOR", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 8);
				Graphics.Blit(temporary, temporary2, DEFBJOCJJKF(), 5);
				Graphics.Blit(temporary2, temporary, IGIAPKPKGPK(), 0);
				NBMPPNFKFLB().SetFloat("_Distortion", Amount * 469f);
				Graphics.Blit(temporary, temporary2, NBMPPNFKFLB(), 8);
				Graphics.Blit(temporary2, temporary, PGPEMMBJOOG(), 1);
				IGIAPKPKGPK().SetTexture("_TimeX", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB(), 0);
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
			NBMPPNFKFLB().SetFloat("SubmitUserVote:", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("_SecondTex", Amount);
			GKILCDHJFEG().SetFloat("Delete events", Threshold);
			GKILCDHJFEG().SetFloat("Player Disconnected", Intensity);
			FLOHGDECHHH().SetFloat("skin.", Precision);
			GKILCDHJFEG().SetVector("_TimeX", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, PGPEMMBJOOG(), 5);
				Graphics.Blit(temporary, temporary2, FLOHGDECHHH(), 2);
				Graphics.Blit(temporary2, temporary, IGIAPKPKGPK(), 0);
				PGPEMMBJOOG().SetFloat("[LevelEditorScene] Print Audio Wave: Start", Amount * 1894f);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 1);
				Graphics.Blit(temporary2, temporary, DEFBJOCJJKF(), 0);
				HKGAONMOBMH().SetTexture("\n\n#", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_NoiseTex");
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
			IGIAPKPKGPK().SetFloat("Gameplay/sun", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("JoystickButton13", Amount);
			IGIAPKPKGPK().SetFloat("/theme", Threshold);
			NBMPPNFKFLB().SetFloat("settings.disablestoryboard", Intensity);
			HEHKGPKLAKK().SetFloat("Reset XP", Precision);
			KAFBNOBOIAJ().SetVector("Done!", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, FLOHGDECHHH(), 1);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 5);
				Graphics.Blit(temporary2, temporary, HEHKGPKLAKK(), 1);
				PGPEMMBJOOG().SetFloat("_Value", Amount * 208f);
				Graphics.Blit(temporary, temporary2, GKILCDHJFEG(), 1);
				Graphics.Blit(temporary2, temporary, KAFBNOBOIAJ(), 0);
				HKGAONMOBMH().SetTexture("_TimeX", temporary);
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
			IGIAPKPKGPK().SetFloat("_TimeX", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Obtain promo Item", Amount);
			HEHKGPKLAKK().SetFloat("&", Threshold);
			HKGAONMOBMH().SetFloat("GameScene", Intensity);
			GKILCDHJFEG().SetFloat("ShadersToggle", Precision);
			KAFBNOBOIAJ().SetVector("player.linea", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 7);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 6);
				Graphics.Blit(temporary2, temporary, HEHKGPKLAKK(), 1);
				IGIAPKPKGPK().SetFloat("_Red_C", Amount * 1527f);
				Graphics.Blit(temporary, temporary2, HKGAONMOBMH(), 6);
				Graphics.Blit(temporary2, temporary, HKGAONMOBMH(), 1);
				DEFBJOCJJKF().SetTexture("Texture3", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF(), 1);
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
			GKILCDHJFEG().SetFloat("_TimeX", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("MultiplayerButton", Amount);
			HKGAONMOBMH().SetFloat("-1", Threshold);
			FLOHGDECHHH().SetFloat("0,1,false", Intensity);
			IGIAPKPKGPK().SetFloat("\n\n#", Precision);
			PGPEMMBJOOG().SetVector("SSAARenderTargetCamera", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, FLOHGDECHHH(), 7);
				Graphics.Blit(temporary, temporary2, NBMPPNFKFLB(), 8);
				Graphics.Blit(temporary2, temporary, NBMPPNFKFLB(), 0);
				KAFBNOBOIAJ().SetFloat("_PositionY", Amount * 1459f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 1);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 0);
				NBMPPNFKFLB().SetTexture("Case-Sensitive", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ(), 0);
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
			HKGAONMOBMH().SetFloat("LoadPlayerSkin", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("RoomDescriptionText", Amount);
			IGIAPKPKGPK().SetFloat("menu.hardcoreinfo", Threshold);
			HKGAONMOBMH().SetFloat("\\\\", Intensity);
			HKGAONMOBMH().SetFloat("CameraFilterPack_AAA_Blood1", Precision);
			DEFBJOCJJKF().SetVector("_Blend", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, IGIAPKPKGPK(), 2);
				Graphics.Blit(temporary, temporary2, NBMPPNFKFLB(), 0);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 0);
				NBPKMLMCHFN.SetFloat("EventData0DropDownList", Amount * 1792f);
				Graphics.Blit(temporary, temporary2, HKGAONMOBMH(), 2);
				Graphics.Blit(temporary2, temporary, PGPEMMBJOOG(), 1);
				PGPEMMBJOOG().SetTexture("st", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG(), 0);
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
			NBPKMLMCHFN.SetFloat("_SearchTex", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_ColorBuffer", Amount);
			NBPKMLMCHFN.SetFloat("/", Threshold);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Pixelisation_OilPaint", Intensity);
			NBMPPNFKFLB().SetFloat("_Value5", Precision);
			IGIAPKPKGPK().SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, FLOHGDECHHH(), 2);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 7);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 0);
				KAFBNOBOIAJ().SetFloat("NO", Amount * 279f);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 5);
				Graphics.Blit(temporary2, temporary, DEFBJOCJJKF(), 1);
				NBMPPNFKFLB().SetTexture("Editor/", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH(), 1);
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
			IGIAPKPKGPK().SetFloat("Observed type is not serializable: ", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("Exit to menu?", Amount);
			GKILCDHJFEG().SetFloat(" Owner called.", Threshold);
			KAFBNOBOIAJ().SetFloat("value", Intensity);
			IGIAPKPKGPK().SetFloat("<color=#", Precision);
			NBMPPNFKFLB().SetVector("_Visualize", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, KAFBNOBOIAJ(), 4);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 5);
				Graphics.Blit(temporary2, temporary, NBMPPNFKFLB(), 1);
				DEFBJOCJJKF().SetFloat("[ResourcesManager] Load audio error: ", Amount * 1637f);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 3);
				Graphics.Blit(temporary2, temporary, FLOHGDECHHH(), 0);
				HEHKGPKLAKK().SetTexture("?", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK(), 0);
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
		SCShader = Shader.Find("http://steamcommunity.com/sharedfiles/filedetails/?id=");
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
			NBMPPNFKFLB().SetFloat("_Y", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("SaveButton", Amount);
			NBPKMLMCHFN.SetFloat("MessageText", Threshold);
			HEHKGPKLAKK().SetFloat("intensity", Intensity);
			NBPKMLMCHFN.SetFloat("workshop.", Precision);
			FLOHGDECHHH().SetVector("_TimeX", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, FLOHGDECHHH(), 1);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 3);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				FLOHGDECHHH().SetFloat("_DotSize", Amount * 1494f);
				Graphics.Blit(temporary, temporary2, PGPEMMBJOOG(), 3);
				Graphics.Blit(temporary2, temporary, IGIAPKPKGPK(), 0);
				HKGAONMOBMH().SetTexture("settings.customdataskin", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG(), 0);
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
			HEHKGPKLAKK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_Far", Amount);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Color_Sepia", Threshold);
			NBMPPNFKFLB().SetFloat("Classical", Intensity);
			DEFBJOCJJKF().SetFloat("No info", Precision);
			PGPEMMBJOOG().SetVector("CameraFilterPack/Gradients_Rainbow", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, PGPEMMBJOOG(), 6);
				Graphics.Blit(temporary, temporary2, FLOHGDECHHH(), 2);
				Graphics.Blit(temporary2, temporary, HKGAONMOBMH(), 0);
				FLOHGDECHHH().SetFloat("_ScreenResolution", Amount * 617f);
				Graphics.Blit(temporary, temporary2, DEFBJOCJJKF(), 7);
				Graphics.Blit(temporary2, temporary, HEHKGPKLAKK(), 0);
				HEHKGPKLAKK().SetTexture("_Parameter", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ(), 0);
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

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("#no");
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
			IGIAPKPKGPK().SetFloat("_ChangeGreen", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("Illegal view ID:", Amount);
			KAFBNOBOIAJ().SetFloat("_Value2", Threshold);
			KAFBNOBOIAJ().SetFloat("_Value4", Intensity);
			GKILCDHJFEG().SetFloat("AvatarImage", Precision);
			FLOHGDECHHH().SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, KAFBNOBOIAJ(), 6);
				Graphics.Blit(temporary, temporary2, IGIAPKPKGPK(), 4);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				KAFBNOBOIAJ().SetFloat("CameraFilterPack/FX_Funk", Amount * 1004f);
				Graphics.Blit(temporary, temporary2, HKGAONMOBMH(), 1);
				Graphics.Blit(temporary2, temporary, HEHKGPKLAKK(), 0);
				IGIAPKPKGPK().SetTexture("_ScreenResolution", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH(), 1);
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
		SCShader = Shader.Find("_Parameter");
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
