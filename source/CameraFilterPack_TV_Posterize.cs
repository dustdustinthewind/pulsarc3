// CameraFilterPack_TV_Posterize
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/Posterize")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Posterize : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(1f, 256f)]
	public float Posterize = 64f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void ANKIJGCGCBF()
	{
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return BJFKDHHMLJH;
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 380f)
			{
				HBJJOCHGOPH = 1520f;
			}
			HCGJCMDJPGD().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("0.000", Fade);
			ADGHJOHKEHG().SetFloat(",", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JEBIBKLHFLB()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find(".lastCheckpoint.powerupsScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 765f)
			{
				HBJJOCHGOPH = 1267f;
			}
			EJDPNJAEAKJ().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Received RPC \"", Fade);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Deep_OilPaintHQ", Posterize);
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
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("_Distortion", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 143f)
			{
				HBJJOCHGOPH = 1631f;
			}
			GJHLADDCMFF().SetFloat("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat(" cannot be used as a 3D LUT.", Fade);
			DNLMFEGJJDD().SetFloat("Map: ", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1798f)
			{
				HBJJOCHGOPH = 1006f;
			}
			LNLKMDPHDCC().SetFloat("Submit", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("File not found: {0}", Fade);
			NLFJGMBCICG().SetFloat("custom", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1641f)
			{
				HBJJOCHGOPH = 630f;
			}
			FEAEGGCNIAA().SetFloat(".message", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_SampleDistance", Fade);
			BAGICADFBAB().SetFloat("_MainTex2", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
	private Material FLGPDBBKAIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find(" argument(s): ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
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

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Subtract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HOMNAHDDNHJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1326f)
			{
				HBJJOCHGOPH = 8f;
			}
			IGKFMCPDNOI().SetFloat("_Value", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("DeleteButton", Fade);
			FLGPDBBKAIP().SetFloat("resource id", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 495f)
			{
				HBJJOCHGOPH = 1429f;
			}
			HCGJCMDJPGD().SetFloat("r", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("(singleton) ", Fade);
			DNLMFEGJJDD().SetFloat("UseScanLine", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 786f)
			{
				HBJJOCHGOPH = 1650f;
			}
			HNFFHCLNBDN().SetFloat("id", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("#newhighscore", Fade);
			LPPEPKGFOEM().SetFloat("note.0", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FAKGFMFAPDG()
	{
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HEBOIFKBLGD()
	{
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 332f)
			{
				HBJJOCHGOPH = 520f;
			}
			BAGICADFBAB().SetFloat("Add Environment Sprite", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("finished", Fade);
			NBPKMLMCHFN.SetFloat("_History4Weight", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("[Up-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return BJFKDHHMLJH;
	}

	private void COGBDFKOHKK()
	{
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("\nCreated by Oxy949");
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

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 791f)
			{
				HBJJOCHGOPH = 176f;
			}
			ADGHJOHKEHG().SetFloat("_TimeX", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat(" not exist", Fade);
			OLHDPICFBOF().SetFloat("mapselector.filter.favoriteonly", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("SetEnvSpriteImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
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

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 400f)
			{
				HBJJOCHGOPH = 1391f;
			}
			DNLMFEGJJDD().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("SpeedSlider", Fade);
			DNLMFEGJJDD().SetFloat(",", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 354f)
			{
				HBJJOCHGOPH = 363f;
			}
			IGKFMCPDNOI().SetFloat("_ScratchOffsetScale", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("BloodAlternative2", Fade);
			NBPKMLMCHFN.SetFloat("Vertical", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void MMBPLGGLPDB()
	{
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 668f)
			{
				HBJJOCHGOPH = 423f;
			}
			FOOCJIDNGBB().SetFloat("Scene", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("ConfigVersionSlider", Fade);
			NLFJGMBCICG().SetFloat("_TimeX", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFOFGJPNCI()
	{
		SCShader = Shader.Find("ns");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("EventMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("_ColorBuffer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("Result for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("0,7,true,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1603f)
			{
				HBJJOCHGOPH = 1181f;
			}
			HKGAONMOBMH().SetFloat("/", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_FixDistance", Fade);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/FX_Screens", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("ChangeSelectedLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("a year ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1101f)
			{
				HBJJOCHGOPH = 1897f;
			}
			EOCCJGIGEGJ().SetFloat("_Tint", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("id", Fade);
			LPMLLJKMAMP().SetFloat("DPADVER", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("SupportLogger OnFailedToConnectToPhoton(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("{STEAM_CLAN_IMAGE}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("GlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMOCDAOKGLI()
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
			if (HBJJOCHGOPH > 594f)
			{
				HBJJOCHGOPH = 417f;
			}
			LPPEPKGFOEM().SetFloat("LivesSlider", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("Hidden/DepthOfField/DepthOfField", Fade);
			ADGHJOHKEHG().SetFloat("NEW_ACHIEVEMENT_1_21", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 960f)
			{
				HBJJOCHGOPH = 380f;
			}
			NLFJGMBCICG().SetFloat("workshop.", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("JoystickButton13", Fade);
			DNLMFEGJJDD().SetFloat(" : ", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1875f)
			{
				HBJJOCHGOPH = 58f;
			}
			LPMLLJKMAMP().SetFloat("SupportLogger OnFailedToConnectToPhoton(", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value4", Fade);
			EHDJJANLINB().SetFloat("/icon", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEMGPJDJGBJ()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 753f)
			{
				HBJJOCHGOPH = 1221f;
			}
			OLHDPICFBOF().SetFloat("Image", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("mapselector.orderby", Fade);
			GJHLADDCMFF().SetFloat(".", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDBBPKIFNJ()
	{
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_AdditiveReflection");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("play");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void ODGMCJILIHF()
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

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1863f)
			{
				HBJJOCHGOPH = 49f;
			}
			KEMAALEODNH().SetFloat("Set Satellite Input", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat(" x ", Fade);
			IONHGBPGCHK().SetFloat(".png", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("UseScanLine");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 916f)
			{
				HBJJOCHGOPH = 1082f;
			}
			LPMLLJKMAMP().SetFloat("SetupEncryption() got called. ", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("Set Background Color", Fade);
			DKKBFFHBHJE().SetFloat("shader.pixel", Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Posterize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}
}
