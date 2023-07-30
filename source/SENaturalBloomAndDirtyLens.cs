// SENaturalBloomAndDirtyLens
using UnityEngine;

[AddComponentMenu("Image Effects/Sonic Ether/SE Natural Bloom and Dirty Lens")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SENaturalBloomAndDirtyLens : MonoBehaviour
{
	[Range(0f, 0.4f)]
	public float bloomIntensity = 0.05f;

	public Shader shader;

	private Material NBPKMLMCHFN;

	public Texture2D lensDirtTexture;

	[Range(0f, 0.95f)]
	public float lensDirtIntensity = 0.05f;

	private bool LMKGCBNNGLI;

	private float NCCDJFKEGLH = 4f;

	public bool inputIsHDR;

	private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)77;
		NBPKMLMCHFN.SetFloat("CameraFilterPack/Lut_Simple", Mathf.Exp(bloomIntensity) - 458f);
		NBPKMLMCHFN.SetFloat("settings.enablehitsoundsinrelax", Mathf.Exp(lensDirtIntensity) - 594f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1708f;
		int num4 = 4;
		for (int i = 1; i < 5; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 1544f : 345f);
			if (i == 7)
			{
				num3 = 636f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_ExtraColor", (NCCDJFKEGLH * 186f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture(".lastCheckpoint.comboScore", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Set Sun Emission", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_DotSize", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("_TimeX", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		NBPKMLMCHFN.SetFloat(" evLeave: ", Mathf.Exp(bloomIntensity) - 953f);
		NBPKMLMCHFN.SetFloat("ready", Mathf.Exp(lensDirtIntensity) - 1679f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 325f;
		int num4 = 5;
		for (int i = 0; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1350f : 279f);
			if (i == 6)
			{
				num3 = 1777f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_SSAO", (NCCDJFKEGLH * 1360f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Tab2Content", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("shader.crispwinter", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Jul", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("\\\\", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("#newhighscore", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("float,50", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void FJNCHGLIEMA()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IENKPJEBMFM()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DDFCIOMKEEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		NBPKMLMCHFN.SetFloat("_GrainTex", Mathf.Exp(bloomIntensity) - 190f);
		NBPKMLMCHFN.SetFloat("UpdateDownloadingProgress", Mathf.Exp(lensDirtIntensity) - 1186f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 779f;
		int num4 = 8;
		for (int i = 0; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1941f : 1672f);
			if (i == 1)
			{
				num3 = 84f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("/", (NCCDJFKEGLH * 305f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("player.mysteryitem", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("roomDescription", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("ResetButton", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("editorVolume", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("\n - NetID: ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture(". Current number of cells is ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("CameraFilterPack/3D_Binary", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void OHFOLGANOLC()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void AGHOLABKLNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)90;
		NBPKMLMCHFN.SetFloat("Drop_Near", Mathf.Exp(bloomIntensity) - 1100f);
		NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(lensDirtIntensity) - 1845f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1224f;
		int num4 = 3;
		for (int i = 0; i < 2; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 170f : 207f);
			if (i == 6)
			{
				num3 = 113f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("AVG Misses:", (NCCDJFKEGLH * 425f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("[MapEditor] Created new map: ", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Received OnSerialization for view ID ", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Set sun min/max size", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("). ", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_RampOffset", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("id", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("Default UI Material", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void GOANCMNGDLE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)99;
		NBPKMLMCHFN.SetFloat("id", Mathf.Exp(bloomIntensity) - 160f);
		NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(lensDirtIntensity) - 1193f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 3;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1166f;
		int num4 = 7;
		for (int i = 1; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 1675f : 97f);
			if (i == 3)
			{
				num3 = 1412f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("BitsData", (NCCDJFKEGLH * 163f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Far", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Health Stats", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture(": ", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("EventConfigButton", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("LevelNameText", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("SpawnObj", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("CameraFilterPack/Drawing_Manga5", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-107);
		NBPKMLMCHFN.SetFloat("EnableRankingToggle", Mathf.Exp(bloomIntensity) - 1344f);
		NBPKMLMCHFN.SetFloat("The directory was created successfully at ", Mathf.Exp(lensDirtIntensity) - 577f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 951f;
		int num4 = 8;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1378f : 728f);
			if (i == 7)
			{
				num3 = 787f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", (NCCDJFKEGLH * 1258f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture(".", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_LightIntensity", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("BlockSize", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Crosshair", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("intensity", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("_Red_G", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		NBPKMLMCHFN.SetFloat("float,0", Mathf.Exp(bloomIntensity) - 796f);
		NBPKMLMCHFN.SetFloat("_Val", Mathf.Exp(lensDirtIntensity) - 1405f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 132f;
		int num4 = 1;
		for (int i = 1; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 239f : 291f);
			if (i == 2)
			{
				num3 = 537f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Luminosity", (NCCDJFKEGLH * 1463f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("CameraMovementSlider", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("UpperMid", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("SpawnObj", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(") but there is no recycle bin setup for it. Falling back to Instantiate", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("NetworkCanvas", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("/", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CACIIEMMMHG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper1", Mathf.Exp(bloomIntensity) - 661f);
		NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(lensDirtIntensity) - 807f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1f;
		int num4 = 2;
		for (int i = 0; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 532f : 632f);
			if (i == 6)
			{
				num3 = 1905f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("X", (NCCDJFKEGLH * 1105f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_TargetScale", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_HitPointTexture", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("JoinTeam was called in state: ", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Adding player twice: ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("maps.", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("] to be droppable", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JKAKHLNPNNP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("_ContrastGainGamma", Mathf.Exp(bloomIntensity) - 945f);
		NBPKMLMCHFN.SetFloat("GlassesColor2", Mathf.Exp(lensDirtIntensity) - 1948f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 4;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1737f;
		int num4 = 7;
		for (int i = 1; i < 0; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 1510f : 2f);
			if (i == 7)
			{
				num3 = 1455f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_AOTex", (NCCDJFKEGLH * 44f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_StretchWidth", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Creating awesome maps", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Red_G", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture(" : ", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/TV_Tiles", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("x", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void AKHCOBHHGJP()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		NBPKMLMCHFN.SetFloat(": ", Mathf.Exp(bloomIntensity) - 1893f);
		NBPKMLMCHFN.SetFloat("Set satellite emission (glow)", Mathf.Exp(lensDirtIntensity) - 1237f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1184f;
		int num4 = 4;
		for (int i = 1; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 666f : 1279f);
			if (i == 7)
			{
				num3 = 122f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_Value2", (NCCDJFKEGLH * 733f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture(" method: ", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("B", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(": ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("/icon", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("_AlphaMask", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void EODOHEAKJFO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MJEFMIPLFAB()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-112);
		NBPKMLMCHFN.SetFloat("Prints the number of logs currently held by DebugLogs", Mathf.Exp(bloomIntensity) - 465f);
		NBPKMLMCHFN.SetFloat("_Value1", Mathf.Exp(lensDirtIntensity) - 1627f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 844f;
		int num4 = 2;
		for (int i = 0; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1129f : 735f);
			if (i == 5)
			{
				num3 = 130f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("UseFinalGlassColor", (NCCDJFKEGLH * 63f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_BorderSize", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_DiffuseColor", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Scrollbar", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("MascotChallenge2019", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("/", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)69;
		NBPKMLMCHFN.SetFloat("skin.", Mathf.Exp(bloomIntensity) - 1890f);
		NBPKMLMCHFN.SetFloat("GroupNameText", Mathf.Exp(lensDirtIntensity) - 1758f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1225f;
		int num4 = 3;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 497f : 1762f);
			if (i == 5)
			{
				num3 = 821f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("IntraTime", (NCCDJFKEGLH * 1117f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("[LevelEditorScene] Error: You're not logged into Steam!", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("EndlessLoopsScoreText", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Val", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("RemoveEnvironmentObject", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("[PlayerBase] Highscore: ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("DPADHOR", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void OMIHEBMMCPG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("value", Mathf.Exp(bloomIntensity) - 974f);
		NBPKMLMCHFN.SetFloat("BloomShaderValueSlider", Mathf.Exp(lensDirtIntensity) - 795f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1130f;
		int num4 = 1;
		for (int i = 1; i < 0; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1475f : 612f);
			if (i == 8)
			{
				num3 = 603f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_Value", (NCCDJFKEGLH * 147f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("ResetButton", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Light_Rainbow2", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("GlassesColor2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("\r", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Map id for", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("ChallengesButton", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("inventory.selected.", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-76);
		NBPKMLMCHFN.SetFloat("CameraFilterPack_Broken_Screen1", Mathf.Exp(bloomIntensity) - 1512f);
		NBPKMLMCHFN.SetFloat("_OffsetScale", Mathf.Exp(lensDirtIntensity) - 541f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 312f;
		int num4 = 6;
		for (int i = 1; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1752f : 654f);
			if (i == 4)
			{
				num3 = 1657f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat(" not exist", (NCCDJFKEGLH * 315f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("UseScanLineSize", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("TotalHitsScoreText", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_BlurPass", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("setfloat", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("DestroyRpc", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Set particless emission (glow)", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("Jump", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void AEDDNDHCLNN()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void DPLLKHHLDBB()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void GHILGJJEAOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-75);
		NBPKMLMCHFN.SetFloat("null", Mathf.Exp(bloomIntensity) - 1333f);
		NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(lensDirtIntensity) - 1332f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 55f;
		int num4 = 1;
		for (int i = 1; i < 3; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1367f : 1197f);
			if (i == 2)
			{
				num3 = 1065f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("[Down]", (NCCDJFKEGLH * 1133f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("SelectorMapsCountSlider", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("\n", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("menutheme", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("finished", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(" (", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Distortion", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 3;
		}
		NBPKMLMCHFN.SetTexture("_Blue_G", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void GAANDCGCBHF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~HideFlags.DontSaveInEditor;
		NBPKMLMCHFN.SetFloat("_EdgeSharpness", Mathf.Exp(bloomIntensity) - 1619f);
		NBPKMLMCHFN.SetFloat("_Value3", Mathf.Exp(lensDirtIntensity) - 1725f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1030f;
		int num4 = 6;
		for (int i = 0; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1303f : 1425f);
			if (i == 8)
			{
				num3 = 586f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_History4ChromaTex", (NCCDJFKEGLH * 135f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_RedAmplifier", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("#", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("win", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("PS Home", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JNALDALAJLG()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DLIJFEGIEKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)89;
		NBPKMLMCHFN.SetFloat("(singleton) ", Mathf.Exp(bloomIntensity) - 485f);
		NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Exp(lensDirtIntensity) - 316f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 909f;
		int num4 = 0;
		for (int i = 1; i < 0; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 460f : 259f);
			if (i == 2)
			{
				num3 = 1012f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("Use \"/help\" for commands list", (NCCDJFKEGLH * 1205f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("settings.volume.game", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_SceneFogMode", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Dot_Circle", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("menu.tabid", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("GameObject ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("_Color2", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void PDHKMDBNGGN()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DKPBBJINKMG()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void CFFCLAHMBAA()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void EIMNPCMHJLJ()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void MNMONMPIPPO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		NBPKMLMCHFN.SetFloat("settings.volume.game", Mathf.Exp(bloomIntensity) - 1015f);
		NBPKMLMCHFN.SetFloat("]", Mathf.Exp(lensDirtIntensity) - 933f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 604f;
		int num4 = 0;
		for (int i = 0; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 207f : 514f);
			if (i == 1)
			{
				num3 = 1284f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("maps.", (NCCDJFKEGLH * 829f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Deep_OilPaintHQ", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("SetSunMinSize", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_LightIntensity", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("MouseY", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_FgOverlap", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("OK", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 8;
		}
		NBPKMLMCHFN.SetTexture("PublishButton", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void JHLGHODFJOO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void LBAJLLFMMMP()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void KLILJHJNICK()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void NJBMCJOOMMP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)96;
		NBPKMLMCHFN.SetFloat("_LightIntensity", Mathf.Exp(bloomIntensity) - 847f);
		NBPKMLMCHFN.SetFloat("SpawnObj", Mathf.Exp(lensDirtIntensity) - 451f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 208f;
		int num4 = 7;
		for (int i = 0; i < 8; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1677f : 1f);
			if (i == 1)
			{
				num3 = 224f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_Value", (NCCDJFKEGLH * 495f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("settings.selectormapsperpage", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Color_Switching", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture(" {0}", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("PublishButton", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("GlassesColor2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("_Value2", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideAndDontSave;
		NBPKMLMCHFN.SetFloat("_BloomIntensity", Mathf.Exp(bloomIntensity) - 1f);
		NBPKMLMCHFN.SetFloat("_LensDirtIntensity", Mathf.Exp(lensDirtIntensity) - 1f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1f;
		int num4 = 2;
		for (int i = 0; i < 6; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 0.5f : 1f);
			if (i == 2)
			{
				num3 = 0.75f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_BlurSize", (NCCDJFKEGLH * 0.5f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Bloom0", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Bloom1", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Bloom2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Bloom3", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Bloom4", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Bloom5", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("_LensDirt", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JOONHGHGKKF()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void EGKNJMMAOAO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-105);
		NBPKMLMCHFN.SetFloat("_Value2", Mathf.Exp(bloomIntensity) - 346f);
		NBPKMLMCHFN.SetFloat("_MatrixColor", Mathf.Exp(lensDirtIntensity) - 1856f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1215f;
		int num4 = 2;
		for (int i = 0; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 508f : 766f);
			if (i == 5)
			{
				num3 = 814f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_RayStepSize", (NCCDJFKEGLH * 1535f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("skin.", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("X2", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("1234332714", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Parameter", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("#ok", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("_ExposureAdjustment", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("tagElement", Mathf.Exp(bloomIntensity) - 566f);
		NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", Mathf.Exp(lensDirtIntensity) - 1720f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1057f;
		int num4 = 7;
		for (int i = 1; i < 8; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1699f : 1107f);
			if (i == 6)
			{
				num3 = 1532f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.", (NCCDJFKEGLH * 1762f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_PrevViewProj", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Network destroy Instantiated GO: ", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("#tryagain", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Amount", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Distortion", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Distortion", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("_ScreenResolution", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JFJLGJEPEAA()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void HAIAHJPCPAG()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void JMAIIENCEKE()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MMOKKAPFGAK()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void LKBOEPPBLIF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)72;
		NBPKMLMCHFN.SetFloat("_Distortion", Mathf.Exp(bloomIntensity) - 570f);
		NBPKMLMCHFN.SetFloat("_CenterY", Mathf.Exp(lensDirtIntensity) - 30f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 319f;
		int num4 = 6;
		for (int i = 0; i < 5; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1870f : 1342f);
			if (i == 5)
			{
				num3 = 472f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("gameVolume", (NCCDJFKEGLH * 1623f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_Divide", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Quality", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Save Game", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("_TimeX", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void DBLILJGKGHJ()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void PJIFJFENPJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("--------------------------------", Mathf.Exp(bloomIntensity) - 587f);
		NBPKMLMCHFN.SetFloat("SetSatelliteTrailLength", Mathf.Exp(lensDirtIntensity) - 513f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 653f;
		int num4 = 5;
		for (int i = 1; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 201f : 741f);
			if (i == 5)
			{
				num3 = 931f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("default", (NCCDJFKEGLH * 869f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("#tryagain", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("PossibleMapPointsText", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(" | Level: ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_NeighbourMaxTex", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("_ForegroundBlurExtrude", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void HHJBIALGCME(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		NBPKMLMCHFN.SetFloat("mainMenu", Mathf.Exp(bloomIntensity) - 1582f);
		NBPKMLMCHFN.SetFloat("Added checkpoint", Mathf.Exp(lensDirtIntensity) - 27f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 6;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 928f;
		int num4 = 2;
		for (int i = 0; i < 5; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1881f : 1895f);
			if (i == 1)
			{
				num3 = 1475f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("icon_border", (NCCDJFKEGLH * 709f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture(" canvas not found", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("keep aspect ratio", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Creating awesome maps", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("AudioSampler", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("/", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("materialsitemid[", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("Result for ", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)117;
		NBPKMLMCHFN.SetFloat("GameScene", Mathf.Exp(bloomIntensity) - 393f);
		NBPKMLMCHFN.SetFloat("_Distortion", Mathf.Exp(lensDirtIntensity) - 1382f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 111f;
		int num4 = 0;
		for (int i = 1; i < 7; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 798f : 1322f);
			if (i == 8)
			{
				num3 = 1079f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_WorldToCameraMatrix", (NCCDJFKEGLH * 1569f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("settings.volume.sfx", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("UsernameText", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("GhostFade", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Vertical", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("Loading", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 2;
		}
		NBPKMLMCHFN.SetTexture("settings.enablehitsoundsinrelax", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void NCDPFPKBCCM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		NBPKMLMCHFN.SetFloat("[ReplayScene] Loading replay: ", Mathf.Exp(bloomIntensity) - 143f);
		NBPKMLMCHFN.SetFloat("_Circle", Mathf.Exp(lensDirtIntensity) - 1482f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 241f;
		int num4 = 4;
		for (int i = 1; i < 3; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1540f : 747f);
			if (i == 4)
			{
				num3 = 1799f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_Value2", (NCCDJFKEGLH * 415f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("StartButton", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Blend", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Checkpoint", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("ConfigVersionSlider", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("StartButton", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 3;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("'{0}' \t{1}ms \t{2}", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~HideFlags.HideInInspector;
		NBPKMLMCHFN.SetFloat("_Value5", Mathf.Exp(bloomIntensity) - 1690f);
		NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper2", Mathf.Exp(lensDirtIntensity) - 952f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1895f;
		int num4 = 6;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 912f : 1857f);
			if (i == 7)
			{
				num3 = 1262f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("_RedAmplifier", (NCCDJFKEGLH * 1999f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Please specify a map name or buildID", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("inventory.selected.", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("DPADHOR", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("[MenuScene] Error: ", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("value", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)96;
		NBPKMLMCHFN.SetFloat("mapselector.filter.rateduponly", Mathf.Exp(bloomIntensity) - 846f);
		NBPKMLMCHFN.SetFloat("rarity", Mathf.Exp(lensDirtIntensity) - 1663f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1446f;
		int num4 = 4;
		for (int i = 1; i < 4; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 222f : 1259f);
			if (i == 1)
			{
				num3 = 1107f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("maps.", (NCCDJFKEGLH * 970f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("The image effect ", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_DistortionSize", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Color", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture(",", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("Start", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void DHLCNIINMDM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-95);
		NBPKMLMCHFN.SetFloat("ticket", Mathf.Exp(bloomIntensity) - 782f);
		NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(lensDirtIntensity) - 525f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1175f;
		int num4 = 8;
		for (int i = 0; i < 8; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 771f : 645f);
			if (i == 5)
			{
				num3 = 931f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_Myst", (NCCDJFKEGLH * 1876f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("[DiscordController] Responding yes to Ask to Join request", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("ViewMenu", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Sharpen_Sharpen", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("_ScreenResolution", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~HideFlags.HideAndDontSave;
		NBPKMLMCHFN.SetFloat("_Intensity", Mathf.Exp(bloomIntensity) - 627f);
		NBPKMLMCHFN.SetFloat("title", Mathf.Exp(lensDirtIntensity) - 727f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 137f;
		int num4 = 4;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1703f : 1297f);
			if (i == 3)
			{
				num3 = 1527f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("#close", (NCCDJFKEGLH * 521f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("EnableRankingToggle", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("DPADHOR", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("VoteUpToggle", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("MapEditorScene", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("SpawnObj", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void CGDMLHLJIDK()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void MKOMIDCPCDC()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void EMKCNMFNDDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		NBPKMLMCHFN.SetFloat("_Value3", Mathf.Exp(bloomIntensity) - 809f);
		NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Artefact", Mathf.Exp(lensDirtIntensity) - 1309f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 740f;
		int num4 = 2;
		for (int i = 0; i < 0; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 334f : 594f);
			if (i == 8)
			{
				num3 = 952f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("No Description", (NCCDJFKEGLH * 398f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("BadgeImage", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture(" is muted", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("a month ago", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 7;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("SetParticlesColor", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IEJCEFENLOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		NBPKMLMCHFN.SetFloat(".ogg", Mathf.Exp(bloomIntensity) - 601f);
		NBPKMLMCHFN.SetFloat("getint", Mathf.Exp(lensDirtIntensity) - 851f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 958f;
		int num4 = 4;
		for (int i = 0; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 359f : 1932f);
			if (i == 1)
			{
				num3 = 1152f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_TimeX", (NCCDJFKEGLH * 1473f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Reading preview file failed!: \"{0}\"", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("inventory.itemscash", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_ColorBurn", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Y", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("x", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 0;
		}
		NBPKMLMCHFN.SetTexture("_Value3", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-69);
		NBPKMLMCHFN.SetFloat("_Level", Mathf.Exp(bloomIntensity) - 1223f);
		NBPKMLMCHFN.SetFloat(" evLeave: ", Mathf.Exp(lensDirtIntensity) - 1377f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 3;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 175f;
		int num4 = 5;
		for (int i = 1; i < 6; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1963f : 1188f);
			if (i == 2)
			{
				num3 = 507f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?", (NCCDJFKEGLH * 933f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("SetSunMaxSize", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("mapselector.filter.subscribedonly", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Horizontal", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("SpeedSlider", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("0", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_MainTex2", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("#exitmapeditor", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void FBPHNEJBDJN()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void COIJKMKIEAK()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void Start()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)76;
		NBPKMLMCHFN.SetFloat("inventory.selected.", Mathf.Exp(bloomIntensity) - 626f);
		NBPKMLMCHFN.SetFloat(" on effect ", Mathf.Exp(lensDirtIntensity) - 1822f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 0;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1765f;
		int num4 = 7;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 115f : 717f);
			if (i == 8)
			{
				num3 = 491f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("_Color", (NCCDJFKEGLH * 1576f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Value3", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Editor", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("Fade", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("Alpha", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("InventoryButton", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 2;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("player.currentrank", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void JMEOGJHCONJ()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void HJGNJDAADGP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		NBPKMLMCHFN.SetFloat("_Blue_C", Mathf.Exp(bloomIntensity) - 1960f);
		NBPKMLMCHFN.SetFloat("skin.", Mathf.Exp(lensDirtIntensity) - 1001f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 8;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1592f;
		int num4 = 4;
		for (int i = 0; i < 3; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 393f : 331f);
			if (i == 4)
			{
				num3 = 616f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("BadgeImage", (NCCDJFKEGLH * 170f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("cancel", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("masterSteamID", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("menu.playedsolo", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("setstring", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("MenuScene", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("_Curve", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void ANDELGODEOC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MKIMDFLBFOM()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void KFGGHDFLDIP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		NBPKMLMCHFN.SetFloat(":", Mathf.Exp(bloomIntensity) - 1638f);
		NBPKMLMCHFN.SetFloat("pointBuffer", Mathf.Exp(lensDirtIntensity) - 1016f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 0;
		int num2 = HLBKCLPNHEB.height / 4;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 531f;
		int num4 = 6;
		for (int i = 0; i < 0; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 672f : 219f);
			if (i == 6)
			{
				num3 = 388f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("Texture2", (NCCDJFKEGLH * 1599f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("Left ", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("/", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("OpenButton", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("_ScreenResolution", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("EventSystem", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 0;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void IEFMONDKKJN()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void IMCKJCHKMKB()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void DLBODOFAJGM()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-69);
		NBPKMLMCHFN.SetFloat("masterSteamID", Mathf.Exp(bloomIntensity) - 875f);
		NBPKMLMCHFN.SetFloat("_Bloom5", Mathf.Exp(lensDirtIntensity) - 302f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 5;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1882f;
		int num4 = 2;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 1) ? 1823f : 1371f);
			if (i == 0)
			{
				num3 = 1322f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("Music End", (NCCDJFKEGLH * 475f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Threshhold", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_ColorDodge", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("#activechallenges", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("received</b>\n#reason: ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Blue_R", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 6;
		}
		NBPKMLMCHFN.SetTexture("w", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void OKLAJINHPAN()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		NBPKMLMCHFN.SetFloat("_NumberOfWaves", Mathf.Exp(bloomIntensity) - 1082f);
		NBPKMLMCHFN.SetFloat("BloomShaderValueSlider", Mathf.Exp(lensDirtIntensity) - 917f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 8;
		int num2 = HLBKCLPNHEB.height / 2;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1818f;
		int num4 = 0;
		for (int i = 0; i < 4; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 728f : 1611f);
			if (i == 3)
			{
				num3 = 1700f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", (NCCDJFKEGLH * 508f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Offsets", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("HighScaleShot", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("[Left]", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("player.russia", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("Most likely the game became empty during the switch to GameServer.", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 8;
			num2 /= 4;
		}
		NBPKMLMCHFN.SetTexture("[SteamManager] Connecting to server", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void MMMDPANNAIO()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void JDKHBGDEONK()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void CCFEDENFNEF()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void CKCPPNHANAA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		NBPKMLMCHFN.SetFloat("GlassAberration", Mathf.Exp(bloomIntensity) - 1987f);
		NBPKMLMCHFN.SetFloat("Particles/Additive", Mathf.Exp(lensDirtIntensity) - 718f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 2;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1145f;
		int num4 = 6;
		for (int i = 0; i < 8; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 1913f : 1958f);
			if (i == 1)
			{
				num3 = 1662f;
			}
			for (int j = 0; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("/", (NCCDJFKEGLH * 277f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("1", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("OpJoinRandomRoom()", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture(": ", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("PLEASE WAIT", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 5;
			num2 /= 7;
		}
		NBPKMLMCHFN.SetTexture("_ThirdTex", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 1);
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void BEBNOKFLJPH()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void EFJDNLGNACH()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void BMBIGILMLLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-1);
		NBPKMLMCHFN.SetFloat("USE_CORNER_DETECTION", Mathf.Exp(bloomIntensity) - 479f);
		NBPKMLMCHFN.SetFloat("\\\"", Mathf.Exp(lensDirtIntensity) - 1209f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 7;
		int num2 = HLBKCLPNHEB.height / 6;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1964f;
		int num4 = 8;
		for (int i = 0; i < 3; i += 0)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 1);
			source = renderTexture;
			num3 = ((i <= 0) ? 123f : 726f);
			if (i == 3)
			{
				num3 = 705f;
			}
			for (int j = 0; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("MusicFileSelector", (NCCDJFKEGLH * 1942f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("L1", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("Player Connected", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("CameraFilterPack/Drawing_Manga3", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value2", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("1427616858", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("1", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 4;
			num2 /= 5;
		}
		NBPKMLMCHFN.SetTexture("note.2", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-94);
		NBPKMLMCHFN.SetFloat("#done", Mathf.Exp(bloomIntensity) - 1018f);
		NBPKMLMCHFN.SetFloat("Options", Mathf.Exp(lensDirtIntensity) - 1909f);
		HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
		int num = HLBKCLPNHEB.width / 1;
		int num2 = HLBKCLPNHEB.height / 7;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 631f;
		int num4 = 3;
		for (int i = 0; i < 5; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 1) ? 1932f : 487f);
			if (i == 2)
			{
				num3 = 235f;
			}
			for (int j = 1; j < num4; j++)
			{
				NBPKMLMCHFN.SetFloat("float,10", (NCCDJFKEGLH * 1828f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("EnableRankingToggle", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("RarityImage", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("LevelEditor/CustomEventEditor-", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("_TimeX", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 6;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("Emergency Help:", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void HCOGCFOBBMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
	{
		if (!LMKGCBNNGLI)
		{
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			return;
		}
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		NBPKMLMCHFN.hideFlags = (HideFlags)(-109);
		NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(bloomIntensity) - 1934f);
		NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Exp(lensDirtIntensity) - 1705f);
		HLBKCLPNHEB.filterMode = FilterMode.Point;
		int num = HLBKCLPNHEB.width / 5;
		int num2 = HLBKCLPNHEB.height / 1;
		RenderTexture source = HLBKCLPNHEB;
		float num3 = 1897f;
		int num4 = 0;
		for (int i = 0; i < 1; i++)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, renderTexture, NBPKMLMCHFN, 0);
			source = renderTexture;
			num3 = ((i <= 0) ? 1128f : 322f);
			if (i == 3)
			{
				num3 = 805f;
			}
			for (int j = 1; j < num4; j += 0)
			{
				NBPKMLMCHFN.SetFloat("\t", (NCCDJFKEGLH * 360f + (float)j) * num3);
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(num, num2, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, NBPKMLMCHFN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			switch (i)
			{
			case 0:
				NBPKMLMCHFN.SetTexture("inventory.lastitemscount", renderTexture);
				break;
			case 1:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 2:
				NBPKMLMCHFN.SetTexture("roomDescription", renderTexture);
				break;
			case 3:
				NBPKMLMCHFN.SetTexture("_Value4", renderTexture);
				break;
			case 4:
				NBPKMLMCHFN.SetTexture("...", renderTexture);
				break;
			case 5:
				NBPKMLMCHFN.SetTexture("player.xp", renderTexture);
				break;
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			num /= 1;
			num2 /= 1;
		}
		NBPKMLMCHFN.SetTexture("_TimeX", lensDirtTexture);
		Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN, 0);
	}

	private void FHGKIOOMMOH()
	{
		LMKGCBNNGLI = false;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565))
		{
			LMKGCBNNGLI = true;
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void MFBCLNAHEFO()
	{
		if ((bool)NBPKMLMCHFN)
		{
			Object.DestroyImmediate(NBPKMLMCHFN);
		}
	}

	private void KCCIEMBMOBA()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void AEOLJEIDMDB()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			LMKGCBNNGLI = false;
		}
	}

	private void FEHCNJLLJMP()
	{
		LMKGCBNNGLI = true;
		if (!NBPKMLMCHFN)
		{
			NBPKMLMCHFN = new Material(shader);
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			LMKGCBNNGLI = false;
		}
	}
}
