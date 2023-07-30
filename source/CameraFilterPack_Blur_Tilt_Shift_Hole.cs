// CameraFilterPack_Blur_Tilt_Shift_Hole
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/Tilt_Shift_Hole")]
public class CameraFilterPack_Blur_Tilt_Shift_Hole : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	public float Amount = 3f;

	[Range(2f, 16f)]
	public int FastFilter = 8;

	[Range(0f, 1f)]
	public float Smooth = 0.5f;

	[Range(0f, 1f)]
	public float Size = 0.2f;

	[Range(-1f, 1f)]
	public float PositionX = 0.5f;

	[Range(-1f, 1f)]
	public float PositionY = 0.5f;

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

	private void KCDOMIJBFLL()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return BJFKDHHMLJH;
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 624f)
			{
				HBJJOCHGOPH = 1342f;
			}
			FAIFBBGFAIB().SetFloat("0,7,true,0", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("MissesText", Amount);
			NLFJGMBCICG().SetFloat("_TimeX", Smooth);
			HCGJCMDJPGD().SetFloat(":\n", Size);
			FEAEGGCNIAA().SetFloat("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", PositionX);
			ACHNOHCLGOO().SetFloat("_Glitch", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, FAIFBBGFAIB(), 1);
				Graphics.Blit(temporary, temporary2, GHHPOGODBHB(), 0);
				PDEAHJPOMEF().SetFloat("_TimeX", Amount * 1326f);
				Graphics.Blit(temporary2, temporary, ABHDNGIHBKE(), 0);
				Graphics.Blit(temporary, temporary2, DBOLLHHMKKN(), 1);
				LONNIJMNKFB().SetTexture("There is already a virtual axis named ", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 842f)
			{
				HBJJOCHGOPH = 227f;
			}
			NDMPCDHADMJ().SetFloat("_Value", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("AudioSampler", Amount);
			GCDFNHMJMIP().SetFloat("View", Smooth);
			NFMGLIKNOOC().SetFloat("BadgeText", Size);
			FEAEGGCNIAA().SetFloat("settings.selectormapsperpage", PositionX);
			LONNIJMNKFB().SetFloat("HightScoreMaxPointsText", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, FHFLKLMFHOI(), 7);
				Graphics.Blit(temporary, temporary2, NDMPCDHADMJ(), 0);
				GCDFNHMJMIP().SetFloat("/", Amount * 1310f);
				Graphics.Blit(temporary2, temporary, JIBOKBCPDLC(), 6);
				Graphics.Blit(temporary, temporary2, FHFLKLMFHOI(), 1);
				ABHDNGIHBKE().SetTexture("<scene_name> or <id>", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("resource id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("Reconnect() disabled the offline mode. No longer offline.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1109f)
			{
				HBJJOCHGOPH = 890f;
			}
			PDEAHJPOMEF().SetFloat("HIDE CONFIG [Ctrl+E]", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("Multiplayer", Amount);
			FHFLKLMFHOI().SetFloat("w", Smooth);
			NFMGLIKNOOC().SetFloat("Bad modpack name: {0}", Size);
			FEAEGGCNIAA().SetFloat("#rt", PositionX);
			FAIFBBGFAIB().SetFloat("_TimeX", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, IIJMIPBMMBF(), 0);
				Graphics.Blit(temporary, temporary2, NDMPCDHADMJ(), 1);
				IIJMIPBMMBF().SetFloat("_FixDistance", Amount * 606f);
				Graphics.Blit(temporary2, temporary, FAIFBBGFAIB(), 8);
				Graphics.Blit(temporary, temporary2, IONHGBPGCHK(), 1);
				IIJMIPBMMBF().SetTexture("z", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1253f)
			{
				HBJJOCHGOPH = 970f;
			}
			GHHPOGODBHB().SetFloat("UseScanLine", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Map id for", Amount);
			IIJMIPBMMBF().SetFloat("_EmissionColor", Smooth);
			IONHGBPGCHK().SetFloat("maps.", Size);
			FHFLKLMFHOI().SetFloat("SpawnObj", PositionX);
			LONNIJMNKFB().SetFloat("_SizeX", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 3);
				Graphics.Blit(temporary, temporary2, ABHDNGIHBKE(), 1);
				GHHPOGODBHB().SetFloat("Oct", Amount * 1621f);
				Graphics.Blit(temporary2, temporary, LONNIJMNKFB(), 2);
				Graphics.Blit(temporary, temporary2, EFDEIFCDAFG(), 1);
				FHFLKLMFHOI().SetTexture(".message", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("Up ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void OEENOOGEEHD()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void DNENFLNCIJP()
	{
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1111f)
			{
				HBJJOCHGOPH = 36f;
			}
			EFDEIFCDAFG().SetFloat("PublishMapButton", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Apr", Amount);
			NDMPCDHADMJ().SetFloat("HandleEventLeave for player ID: ", Smooth);
			BKKJJJGADLM().SetFloat("maps.", Size);
			FAIFBBGFAIB().SetFloat("OpAuthenticate()", PositionX);
			FHFLKLMFHOI().SetFloat("_TimeX", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, ABHDNGIHBKE(), 6);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 0);
				EFDEIFCDAFG().SetFloat("_MainTex2", Amount * 1654f);
				Graphics.Blit(temporary2, temporary, FHFLKLMFHOI(), 4);
				Graphics.Blit(temporary, temporary2, GHHPOGODBHB(), 0);
				ABHDNGIHBKE().SetTexture("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("Source directory does not exist or could not be found: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 700f)
			{
				HBJJOCHGOPH = 944f;
			}
			PDEAHJPOMEF().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Write me to get one for testing :)", Amount);
			IIJMIPBMMBF().SetFloat("ChangeSelectedLevel", Smooth);
			LONNIJMNKFB().SetFloat("http", Size);
			GCDFNHMJMIP().SetFloat("id", PositionX);
			IIJMIPBMMBF().SetFloat("downloading", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, PDEAHJPOMEF(), 2);
				Graphics.Blit(temporary, temporary2, ACHNOHCLGOO(), 0);
				EFDEIFCDAFG().SetFloat("From {0} at Index {1} \n", Amount * 390f);
				Graphics.Blit(temporary2, temporary, FEAEGGCNIAA(), 0);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 0);
				NLFJGMBCICG().SetTexture("Tab2Content", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG(), 0);
			}
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
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1604f)
			{
				HBJJOCHGOPH = 393f;
			}
			EFDEIFCDAFG().SetFloat("Xbox Home", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("_MainTex2", Amount);
			ACHNOHCLGOO().SetFloat("lobby '{0}'[{1}]", Smooth);
			FEAEGGCNIAA().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", Size);
			GHHPOGODBHB().SetFloat("_Value4", PositionX);
			IIJMIPBMMBF().SetFloat("Data/Skins/", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 7);
				Graphics.Blit(temporary, temporary2, FHFLKLMFHOI(), 0);
				GCDFNHMJMIP().SetFloat("skin.", Amount * 97f);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 6);
				Graphics.Blit(temporary, temporary2, HCGJCMDJPGD(), 0);
				HCGJCMDJPGD().SetTexture("Joystick1Button6", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 287f)
			{
				HBJJOCHGOPH = 765f;
			}
			IIJMIPBMMBF().SetFloat("Set Trail Zoom Speed", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("(\\[ *i *\\])", Amount);
			DBOLLHHMKKN().SetFloat("LoadMapCanvas", Smooth);
			ACHNOHCLGOO().SetFloat("_Distortion", Size);
			FHFLKLMFHOI().SetFloat("_Value10", PositionX);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_BleachBypass", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, FHFLKLMFHOI(), 4);
				Graphics.Blit(temporary, temporary2, FEAEGGCNIAA(), 0);
				FHFLKLMFHOI().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", Amount * 1743f);
				Graphics.Blit(temporary2, temporary, ACHNOHCLGOO(), 8);
				Graphics.Blit(temporary, temporary2, NLFJGMBCICG(), 0);
				NBPKMLMCHFN.SetTexture("513510", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("14");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGDDCINLDAD()
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

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("_Blue_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("_WorldToCameraMatrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 330f)
			{
				HBJJOCHGOPH = 358f;
			}
			EFDEIFCDAFG().SetFloat("SpawnObj", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_MainTex2", Amount);
			FHFLKLMFHOI().SetFloat("_EmissionColor", Smooth);
			IIJMIPBMMBF().SetFloat("Horizontal", Size);
			IONHGBPGCHK().SetFloat("_Offsets", PositionX);
			EFDEIFCDAFG().SetFloat("LevelNameInputField", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, FAIFBBGFAIB(), 8);
				Graphics.Blit(temporary, temporary2, IIJMIPBMMBF(), 0);
				LONNIJMNKFB().SetFloat("settings.volume.sfx", Amount * 109f);
				Graphics.Blit(temporary2, temporary, IIJMIPBMMBF(), 0);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 1);
				PDEAHJPOMEF().SetTexture("SetSunEmission", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/BlurTiltShift_Hole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1185f)
			{
				HBJJOCHGOPH = 875f;
			}
			LONNIJMNKFB().SetFloat("[Up]", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Protocol switch from: ", Amount);
			EFDEIFCDAFG().SetFloat("CONTRAST", Smooth);
			IONHGBPGCHK().SetFloat("SetSpeed", Size);
			ABHDNGIHBKE().SetFloat("st", PositionX);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_Grid", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, PDEAHJPOMEF(), 7);
				Graphics.Blit(temporary, temporary2, HCGJCMDJPGD(), 0);
				NLFJGMBCICG().SetFloat("shaders", Amount * 1356f);
				Graphics.Blit(temporary2, temporary, ABHDNGIHBKE(), 5);
				Graphics.Blit(temporary, temporary2, FEAEGGCNIAA(), 0);
				FHFLKLMFHOI().SetTexture("_ScreenResolution", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
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
			NBPKMLMCHFN.SetFloat("_Value1", Smooth);
			NBPKMLMCHFN.SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetFloat("_Value3", PositionX);
			NBPKMLMCHFN.SetFloat("_Value4", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("_Amount", Amount * 2f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetTexture("_MainTex2", temporary2);
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

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1042f)
			{
				HBJJOCHGOPH = 1076f;
			}
			NBPKMLMCHFN.SetFloat("PRESS A KEY", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("menu.tabid", Amount);
			NBPKMLMCHFN.SetFloat("ItemNameText", Smooth);
			NLFJGMBCICG().SetFloat("PlaySound", Size);
			HCGJCMDJPGD().SetFloat("1 Kb", PositionX);
			JIBOKBCPDLC().SetFloat("LevelFolderInputField", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 0);
				Graphics.Blit(temporary, temporary2, FHFLKLMFHOI(), 0);
				IONHGBPGCHK().SetFloat("y", Amount * 1156f);
				Graphics.Blit(temporary2, temporary, GCDFNHMJMIP(), 1);
				Graphics.Blit(temporary, temporary2, HCGJCMDJPGD(), 0);
				FAIFBBGFAIB().SetTexture("settings.arcsdestroydelay", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HNDNDPECBPL()
	{
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 838f)
			{
				HBJJOCHGOPH = 1027f;
			}
			BKKJJJGADLM().SetFloat("RT", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("_ColorBuffer", Amount);
			EFDEIFCDAFG().SetFloat("_Value2", Smooth);
			NBPKMLMCHFN.SetFloat("_PixelsPerMeterAtOneMeter", Size);
			BKKJJJGADLM().SetFloat("BitsData", PositionX);
			FEAEGGCNIAA().SetFloat("team", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 3);
				Graphics.Blit(temporary, temporary2, JIBOKBCPDLC(), 1);
				FAIFBBGFAIB().SetFloat("speed", Amount * 215f);
				Graphics.Blit(temporary2, temporary, NDMPCDHADMJ(), 4);
				Graphics.Blit(temporary, temporary2, JIBOKBCPDLC(), 1);
				ABHDNGIHBKE().SetTexture("[PlayerBase] MapEnd error: ", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1413f)
			{
				HBJJOCHGOPH = 1751f;
			}
			NDMPCDHADMJ().SetFloat("settings.hideui", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("No Name", Amount);
			BKKJJJGADLM().SetFloat("ViewMenu", Smooth);
			NDMPCDHADMJ().SetFloat("value", Size);
			FHFLKLMFHOI().SetFloat("&search=", PositionX);
			PDEAHJPOMEF().SetFloat("IntraSig", PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, FEAEGGCNIAA(), 3);
				Graphics.Blit(temporary, temporary2, FHFLKLMFHOI(), 1);
				NLFJGMBCICG().SetFloat("/", Amount * 1023f);
				Graphics.Blit(temporary2, temporary, GCDFNHMJMIP(), 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 1);
				GHHPOGODBHB().SetTexture("NEW_ACHIEVEMENT_1_", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA(), 1);
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

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("VoteDownToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("<color=#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
