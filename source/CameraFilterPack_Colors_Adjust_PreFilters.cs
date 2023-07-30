// CameraFilterPack_Colors_Adjust_PreFilters
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/ColorsAdjust/Photo Filters")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_Adjust_PreFilters : MonoBehaviour
{
	public enum filters
	{
		Normal,
		BlueLagoon,
		BlueMoon,
		RedWhite,
		NashVille,
		VintageYellow,
		GoldenPink,
		DarkPink,
		PopRocket,
		RedSoftLight,
		YellowSunSet,
		Walden,
		WhiteShine,
		Fluo,
		MarsSunRise,
		Amelie,
		BlueJeans,
		NightVision,
		BlueParadise,
		Blindness_Deuteranomaly,
		Blindness_Protanopia,
		Blindness_Protanomaly,
		Blindness_Deuteranopia,
		Blindness_Tritanomaly,
		Blindness_Achromatopsia,
		Blindness_Achromatomaly,
		Blindness_Tritanopia,
		BlackAndWhite_Blue,
		BlackAndWhite_Green,
		BlackAndWhite_Orange,
		BlackAndWhite_Red,
		BlackAndWhite_Yellow
	}

	private string ELOFMLPCCEA = "CameraFilterPack/Colors_Adjust_PreFilters";

	public Shader SCShader;

	public filters filterchoice;

	[Range(0f, 1f)]
	public float FadeFX = 1f;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	private float[] PLKFKNHPEHE;

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

	private void Update()
	{
	}

	private void KIMMMCJFMAB()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MIPGPMKJELI()
	{
		if (filterchoice == filters.Normal)
		{
			PLKFKNHPEHE = new float[12]
			{
				100f, 0f, 0f, 0f, 100f, 0f, 0f, 0f, 100f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Deuteranomaly)
		{
			PLKFKNHPEHE = new float[12]
			{
				80f, 20f, 0f, 25.833f, 74.167f, 0f, 0f, 14.167f, 85.833f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Protanopia)
		{
			PLKFKNHPEHE = new float[12]
			{
				56.667f, 43.333f, 0f, 55.833f, 44.167f, 0f, 0f, 24.167f, 75.833f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Protanomaly)
		{
			PLKFKNHPEHE = new float[12]
			{
				81.667f, 18.333f, 0f, 33.333f, 66.667f, 0f, 0f, 12.5f, 87.5f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Deuteranopia)
		{
			PLKFKNHPEHE = new float[12]
			{
				62.5f, 37.5f, 0f, 70f, 30f, 0f, 0f, 30f, 70f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Tritanomaly)
		{
			PLKFKNHPEHE = new float[12]
			{
				96.667f, 3.333f, 0f, 0f, 73.333f, 26.667f, 0f, 18.333f, 81.667f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Achromatopsia)
		{
			PLKFKNHPEHE = new float[12]
			{
				29.9f, 58.7f, 11.4f, 29.9f, 58.7f, 11.4f, 29.9f, 58.7f, 11.4f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Achromatomaly)
		{
			PLKFKNHPEHE = new float[12]
			{
				61.8f, 32f, 6.2f, 16.3f, 77.5f, 6.2f, 16.3f, 32f, 51.6f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Blindness_Tritanopia)
		{
			PLKFKNHPEHE = new float[12]
			{
				95f, 5f, 0f, 0f, 43.333f, 56.667f, 0f, 47.5f, 52.5f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.BlueLagoon)
		{
			PLKFKNHPEHE = new float[12]
			{
				100f, 102f, 0f, 18f, 100f, 4f, 28f, -26f, 100f, -64f,
				0f, 12f
			};
		}
		if (filterchoice == filters.GoldenPink)
		{
			PLKFKNHPEHE = new float[12]
			{
				70f, 200f, 0f, 0f, 100f, 8f, 6f, 12f, 110f, 0f,
				0f, -6f
			};
		}
		if (filterchoice == filters.BlueMoon)
		{
			PLKFKNHPEHE = new float[12]
			{
				200f, 98f, -116f, 24f, 100f, 2f, 30f, 52f, 20f, -48f,
				-20f, 12f
			};
		}
		if (filterchoice == filters.DarkPink)
		{
			PLKFKNHPEHE = new float[12]
			{
				60f, 112f, 36f, 24f, 100f, 2f, 0f, -26f, 100f, -56f,
				-20f, 12f
			};
		}
		if (filterchoice == filters.RedWhite)
		{
			PLKFKNHPEHE = new float[12]
			{
				-42f, 68f, 108f, -96f, 100f, 116f, -92f, 104f, 96f, 0f,
				2f, 4f
			};
		}
		if (filterchoice == filters.VintageYellow)
		{
			PLKFKNHPEHE = new float[12]
			{
				200f, 109f, -104f, 42f, 126f, -1f, -40f, 121f, -31f, -48f,
				-20f, 12f
			};
		}
		if (filterchoice == filters.NashVille)
		{
			PLKFKNHPEHE = new float[12]
			{
				130f, 8f, 7f, 19f, 89f, 3f, -1f, 11f, 57f, 10f,
				19f, 47f
			};
		}
		if (filterchoice == filters.PopRocket)
		{
			PLKFKNHPEHE = new float[12]
			{
				100f, 6f, -17f, 0f, 107f, 0f, 10f, 21f, 100f, 40f,
				0f, 8f
			};
		}
		if (filterchoice == filters.RedSoftLight)
		{
			PLKFKNHPEHE = new float[12]
			{
				-4f, 200f, -30f, -58f, 200f, -30f, -58f, 200f, -30f, -11f,
				0f, 0f
			};
		}
		if (filterchoice == filters.BlackAndWhite_Blue)
		{
			PLKFKNHPEHE = new float[12]
			{
				0f, 0f, 100f, 0f, 0f, 100f, 0f, 0f, 100f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.BlackAndWhite_Green)
		{
			PLKFKNHPEHE = new float[12]
			{
				0f, 100f, 0f, 0f, 100f, 0f, 0f, 100f, 0f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.BlackAndWhite_Orange)
		{
			PLKFKNHPEHE = new float[12]
			{
				50f, 50f, 0f, 50f, 50f, 0f, 50f, 50f, 0f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.BlackAndWhite_Red)
		{
			PLKFKNHPEHE = new float[12]
			{
				100f, 0f, 0f, 100f, 0f, 0f, 100f, 0f, 0f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.BlackAndWhite_Yellow)
		{
			PLKFKNHPEHE = new float[12]
			{
				34f, 66f, 0f, 34f, 66f, 0f, 34f, 66f, 0f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.YellowSunSet)
		{
			PLKFKNHPEHE = new float[12]
			{
				117f, -6f, 53f, -68f, 135f, 19f, -146f, -61f, 200f, 0f,
				0f, 0f
			};
		}
		if (filterchoice == filters.Walden)
		{
			PLKFKNHPEHE = new float[12]
			{
				99f, 2f, 13f, 100f, 1f, 40f, 50f, 8f, 71f, 0f,
				2f, 7f
			};
		}
		if (filterchoice == filters.WhiteShine)
		{
			PLKFKNHPEHE = new float[12]
			{
				190f, 24f, -33f, 2f, 200f, -6f, -10f, 27f, 200f, -6f,
				-13f, 15f
			};
		}
		if (filterchoice == filters.Fluo)
		{
			PLKFKNHPEHE = new float[12]
			{
				100f, 0f, 0f, 0f, 113f, 0f, 200f, -200f, -200f, 0f,
				0f, 36f
			};
		}
		if (filterchoice == filters.MarsSunRise)
		{
			PLKFKNHPEHE = new float[12]
			{
				50f, 141f, -81f, -17f, 62f, 29f, -159f, -137f, -200f, 7f,
				-34f, -6f
			};
		}
		if (filterchoice == filters.Amelie)
		{
			PLKFKNHPEHE = new float[12]
			{
				100f, 11f, 39f, 1f, 63f, 53f, -24f, 71f, 20f, -25f,
				-10f, -24f
			};
		}
		if (filterchoice == filters.BlueJeans)
		{
			PLKFKNHPEHE = new float[12]
			{
				181f, 11f, 15f, 40f, 40f, 20f, 40f, 40f, 20f, -59f,
				0f, 0f
			};
		}
		if (filterchoice == filters.NightVision)
		{
			PLKFKNHPEHE = new float[12]
			{
				200f, -200f, -200f, 195f, 4f, -160f, 200f, -200f, -200f, -200f,
				10f, -200f
			};
		}
		if (filterchoice == filters.BlueParadise)
		{
			PLKFKNHPEHE = new float[12]
			{
				66f, 200f, -200f, 25f, 38f, 36f, 30f, 150f, 114f, 17f,
				0f, 65f
			};
		}
	}

	private void POPFEPMJDPF()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[-75];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)(-6))
		{
			float[] array2 = new float[58];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)(-104))
		{
			float[] array3 = new float[101];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)62)
		{
			float[] array4 = new float[102];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)(-26))
		{
			float[] array5 = new float[-94];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)(-98))
		{
			float[] array6 = new float[119];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)(-17))
		{
			float[] array7 = new float[-93];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)(-125))
		{
			float[] array8 = new float[-63];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == (filters)42)
		{
			float[] array9 = new float[102];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array10 = new float[-80];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.PopRocket)
		{
			float[] array11 = new float[-125];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.BlueMoon)
		{
			float[] array12 = new float[-16];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.PopRocket)
		{
			float[] array13 = new float[29];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.RedWhite)
		{
			float[] array14 = new float[-89];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array15 = new float[-60];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array16 = new float[120];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array17 = new float[59];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)51)
		{
			float[] array18 = new float[-51];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)99)
		{
			float[] array19 = new float[63];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)52)
		{
			float[] array20 = new float[78];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)78)
		{
			PLKFKNHPEHE = new float[5] { 50f, 50f, 0f, 50f, 50f };
		}
		if (filterchoice == (filters)117)
		{
			float[] array21 = new float[-109];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)(-54))
		{
			float[] array22 = new float[118];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)(-80))
		{
			float[] array23 = new float[48];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)105)
		{
			float[] array24 = new float[73];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)96)
		{
			float[] array25 = new float[-60];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)(-58))
		{
			float[] array26 = new float[-120];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)115)
		{
			float[] array27 = new float[-75];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == filters.Fluo)
		{
			float[] array28 = new float[63];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)(-121))
		{
			float[] array29 = new float[74];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == (filters)(-126))
		{
			float[] array30 = new float[127];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
		if (filterchoice == (filters)(-79))
		{
			float[] array31 = new float[24];
			RuntimeHelpers.InitializeArray(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array31;
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void LBEHKFNPKMC()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[-76];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)103)
		{
			float[] array2 = new float[-117];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)114)
		{
			float[] array3 = new float[110];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)38)
		{
			float[] array4 = new float[83];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == filters.Blindness_Tritanopia)
		{
			float[] array5 = new float[-115];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)44)
		{
			float[] array6 = new float[-105];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)51)
		{
			float[] array7 = new float[-118];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)(-3))
		{
			float[] array8 = new float[-16];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == (filters)96)
		{
			float[] array9 = new float[70];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array10 = new float[117];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.PopRocket)
		{
			float[] array11 = new float[-67];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.PopRocket)
		{
			float[] array12 = new float[-9];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array13 = new float[-55];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.RedWhite)
		{
			float[] array14 = new float[96];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array15 = new float[13];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array16 = new float[54];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == filters.BlueMoon)
		{
			float[] array17 = new float[-15];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)(-29))
		{
			float[] array18 = new float[-63];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)101)
		{
			float[] array19 = new float[-75];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)(-42))
		{
			float[] array20 = new float[49];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)102)
		{
			float[] array21 = new float[-106];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)(-21))
		{
			float[] array22 = new float[-101];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == filters.BlackAndWhite_Orange)
		{
			float[] array23 = new float[-3];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)(-3))
		{
			float[] array24 = new float[91];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)(-87))
		{
			float[] array25 = new float[-55];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)89)
		{
			float[] array26 = new float[-45];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)(-72))
		{
			float[] array27 = new float[-72];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)(-65))
		{
			PLKFKNHPEHE = new float[5] { 50f, 141f, -81f, -17f, 62f };
		}
		if (filterchoice == (filters)115)
		{
			float[] array28 = new float[-10];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)39)
		{
			float[] array29 = new float[48];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == (filters)(-119))
		{
			float[] array30 = new float[-15];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
		if (filterchoice == (filters)(-4))
		{
			float[] array31 = new float[104];
			RuntimeHelpers.InitializeArray(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array31;
		}
	}

	private void FIKFJDFELIP()
	{
		HBFMIBFLMJP();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DJGJOMFJPEF()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[36];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)44)
		{
			float[] array2 = new float[-53];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)82)
		{
			float[] array3 = new float[-47];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)(-3))
		{
			float[] array4 = new float[100];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)(-25))
		{
			float[] array5 = new float[104];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)(-91))
		{
			float[] array6 = new float[-12];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)(-52))
		{
			float[] array7 = new float[56];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)(-65))
		{
			float[] array8 = new float[35];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == (filters)58)
		{
			float[] array9 = new float[72];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array10 = new float[-124];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array11 = new float[63];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array12 = new float[-76];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.RedWhite)
		{
			float[] array13 = new float[-49];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array14 = new float[-5];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array15 = new float[103];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array16 = new float[121];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array17 = new float[-75];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)(-60))
		{
			float[] array18 = new float[32];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)41)
		{
			float[] array19 = new float[112];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)(-19))
		{
			float[] array20 = new float[35];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)(-102))
		{
			float[] array21 = new float[-56];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)115)
		{
			float[] array22 = new float[-107];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)122)
		{
			float[] array23 = new float[-78];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == filters.BlackAndWhite_Orange)
		{
			float[] array24 = new float[111];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)86)
		{
			float[] array25 = new float[92];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == filters.Blindness_Protanopia)
		{
			float[] array26 = new float[36];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == filters.Amelie)
		{
			PLKFKNHPEHE = new float[5] { 100f, 0f, 0f, 0f, 113f };
		}
		if (filterchoice == (filters)(-31))
		{
			float[] array27 = new float[-57];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)105)
		{
			float[] array28 = new float[-10];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)(-121))
		{
			float[] array29 = new float[-79];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == (filters)40)
		{
			PLKFKNHPEHE = new float[12]
			{
				200f, -200f, -200f, 195f, 4f, -160f, 200f, -200f, -200f, -200f,
				10f, -200f
			};
		}
		if (filterchoice == (filters)(-10))
		{
			float[] array30 = new float[67];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
	}

	private void HEDFBCFGDLF()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[21];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)43)
		{
			float[] array2 = new float[23];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)(-19))
		{
			float[] array3 = new float[127];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)115)
		{
			float[] array4 = new float[-124];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == filters.BlackAndWhite_Orange)
		{
			float[] array5 = new float[93];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)(-100))
		{
			float[] array6 = new float[28];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)(-123))
		{
			float[] array7 = new float[70];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)(-72))
		{
			float[] array8 = new float[43];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == (filters)(-43))
		{
			float[] array9 = new float[121];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array10 = new float[91];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array11 = new float[-128];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.BlueMoon)
		{
			float[] array12 = new float[-40];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.BlueMoon)
		{
			float[] array13 = new float[78];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array14 = new float[-51];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array15 = new float[-41];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array16 = new float[98];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array17 = new float[14];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)127)
		{
			float[] array18 = new float[-128];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)(-8))
		{
			float[] array19 = new float[54];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)35)
		{
			float[] array20 = new float[-3];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)115)
		{
			float[] array21 = new float[95];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)(-103))
		{
			float[] array22 = new float[-36];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)52)
		{
			float[] array23 = new float[-66];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)(-53))
		{
			float[] array24 = new float[27];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)(-84))
		{
			float[] array25 = new float[89];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)(-101))
		{
			float[] array26 = new float[59];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)41)
		{
			float[] array27 = new float[-92];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)(-86))
		{
			float[] array28 = new float[-59];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)(-100))
		{
			float[] array29 = new float[-99];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == filters.Blindness_Achromatopsia)
		{
			float[] array30 = new float[-20];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array31 = new float[-67];
			RuntimeHelpers.InitializeArray(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array31;
		}
		if (filterchoice == (filters)(-32))
		{
			float[] array32 = new float[-97];
			RuntimeHelpers.InitializeArray(array32, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array32;
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void FINDGJLEHOL()
	{
		GPHHNFDCFMC();
	}

	private void CNGAJDBOCLJ()
	{
		HEDFBCFGDLF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHHNFDCFMC()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[-4];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)72)
		{
			float[] array2 = new float[-112];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)33)
		{
			float[] array3 = new float[-96];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)(-61))
		{
			float[] array4 = new float[-62];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)74)
		{
			float[] array5 = new float[71];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)(-113))
		{
			float[] array6 = new float[-25];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)(-101))
		{
			float[] array7 = new float[-53];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array8 = new float[102];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == (filters)39)
		{
			float[] array9 = new float[61];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			PLKFKNHPEHE = new float[8] { 100f, 102f, 0f, 18f, 100f, 4f, 28f, -26f };
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array10 = new float[67];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array11 = new float[-72];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.PopRocket)
		{
			float[] array12 = new float[-77];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array13 = new float[57];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.BlueMoon)
		{
			float[] array14 = new float[-92];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array15 = new float[70];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array16 = new float[-18];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == (filters)(-3))
		{
			float[] array17 = new float[-40];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)108)
		{
			float[] array18 = new float[-2];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)(-5))
		{
			float[] array19 = new float[-104];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == filters.YellowSunSet)
		{
			float[] array20 = new float[91];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)(-1))
		{
			float[] array21 = new float[-112];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)(-40))
		{
			float[] array22 = new float[24];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)(-64))
		{
			float[] array23 = new float[84];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)(-94))
		{
			float[] array24 = new float[70];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)92)
		{
			float[] array25 = new float[18];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)(-112))
		{
			float[] array26 = new float[13];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)59)
		{
			float[] array27 = new float[-4];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)(-45))
		{
			float[] array28 = new float[-38];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == filters.BlueParadise)
		{
			float[] array29 = new float[-55];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == (filters)(-76))
		{
			float[] array30 = new float[68];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
		if (filterchoice == (filters)70)
		{
			float[] array31 = new float[49];
			RuntimeHelpers.InitializeArray(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array31;
		}
	}

	private void LOOGLMFBJHK()
	{
		DJGJOMFJPEF();
	}

	private void LPMINJJPDCH()
	{
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void NEKCPLGFOFD()
	{
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HBFMIBFLMJP()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[-110];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)(-4))
		{
			float[] array2 = new float[54];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)92)
		{
			float[] array3 = new float[56];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)(-36))
		{
			float[] array4 = new float[-60];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)(-31))
		{
			PLKFKNHPEHE = new float[1] { 62.5f };
		}
		if (filterchoice == (filters)(-74))
		{
			float[] array5 = new float[-120];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == filters.Normal)
		{
			PLKFKNHPEHE = new float[8] { 29.9f, 58.7f, 11.4f, 29.9f, 58.7f, 11.4f, 29.9f, 58.7f };
		}
		if (filterchoice == (filters)34)
		{
			float[] array6 = new float[-22];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)84)
		{
			float[] array7 = new float[48];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array8 = new float[-42];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array9 = new float[115];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array10 = new float[-5];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array11 = new float[60];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array12 = new float[-50];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array13 = new float[25];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array14 = new float[64];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.BlueMoon)
		{
			float[] array15 = new float[-91];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == (filters)(-95))
		{
			float[] array16 = new float[104];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == (filters)(-112))
		{
			float[] array17 = new float[113];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)(-30))
		{
			float[] array18 = new float[32];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)64)
		{
			float[] array19 = new float[126];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)(-89))
		{
			float[] array20 = new float[54];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)(-65))
		{
			float[] array21 = new float[-117];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)(-8))
		{
			float[] array22 = new float[67];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == filters.RedWhite)
		{
			PLKFKNHPEHE = new float[3] { 99f, 2f, 13f };
		}
		if (filterchoice == (filters)(-100))
		{
			float[] array23 = new float[120];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)47)
		{
			float[] array24 = new float[107];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)(-112))
		{
			float[] array25 = new float[-9];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)77)
		{
			float[] array26 = new float[-42];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == filters.Blindness_Protanopia)
		{
			float[] array27 = new float[116];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)39)
		{
			float[] array28 = new float[-21];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)97)
		{
			float[] array29 = new float[65];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 818f)
			{
				HBJJOCHGOPH = 78f;
			}
			HKGAONMOBMH().SetFloat("Left", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("Tab2Content", PLKFKNHPEHE[0] / 1768f);
			PGPEMMBJOOG().SetFloat("Set particles color", PLKFKNHPEHE[1] / 1383f);
			PDEAHJPOMEF().SetFloat("Tab2Content", PLKFKNHPEHE[0] / 886f);
			FAIFBBGFAIB().SetFloat("_Red_B", PLKFKNHPEHE[0] / 412f);
			BFGNMFCNDBC().SetFloat("_HardBlend", PLKFKNHPEHE[4] / 775f);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/FX_Ascii", PLKFKNHPEHE[4] / 1038f);
			HKGAONMOBMH().SetFloat("Error: Someone else(", PLKFKNHPEHE[3] / 557f);
			FAIFBBGFAIB().SetFloat("_Far", PLKFKNHPEHE[2] / 1412f);
			PGPEMMBJOOG().SetFloat("addNewButton", PLKFKNHPEHE[2] / 458f);
			BFGNMFCNDBC().SetFloat("turn: {0:0}", PLKFKNHPEHE[53] / 1284f);
			FAIFBBGFAIB().SetFloat("PS Home", PLKFKNHPEHE[-109] / 600f);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Blend2Camera_PinLight", PLKFKNHPEHE[-70] / 229f);
			FAIFBBGFAIB().SetFloat("DPADHOR", FadeFX);
			HKGAONMOBMH().SetVector("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 935f, 537f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnValidate()
	{
		MIPGPMKJELI();
	}

	private void MMBPLGGLPDB()
	{
	}

	private void DNENFLNCIJP()
	{
	}

	private void DAHFFNNIGML()
	{
		MHNCEEDIKCC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DAJPHCOFNMG()
	{
		if (filterchoice == filters.Normal)
		{
			PLKFKNHPEHE = new float[3] { 100f, 0f, 0f };
		}
		if (filterchoice == (filters)40)
		{
			float[] array = new float[-111];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)121)
		{
			float[] array2 = new float[-32];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)58)
		{
			float[] array3 = new float[77];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)(-32))
		{
			float[] array4 = new float[64];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)72)
		{
			float[] array5 = new float[-41];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)(-107))
		{
			float[] array6 = new float[-82];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)(-123))
		{
			float[] array7 = new float[49];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)(-8))
		{
			float[] array8 = new float[52];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array9 = new float[80];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.NashVille)
		{
			PLKFKNHPEHE = new float[1] { 70f };
		}
		if (filterchoice == filters.RedWhite)
		{
			float[] array10 = new float[36];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array11 = new float[-3];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array12 = new float[36];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array13 = new float[-100];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array14 = new float[-111];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array15 = new float[27];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == (filters)108)
		{
			float[] array16 = new float[103];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == (filters)(-75))
		{
			float[] array17 = new float[-19];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)(-90))
		{
			float[] array18 = new float[-89];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)34)
		{
			float[] array19 = new float[-121];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)(-51))
		{
			float[] array20 = new float[-45];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)41)
		{
			float[] array21 = new float[67];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)67)
		{
			float[] array22 = new float[-8];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)85)
		{
			float[] array23 = new float[111];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)54)
		{
			float[] array24 = new float[24];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)54)
		{
			float[] array25 = new float[-125];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)48)
		{
			float[] array26 = new float[-86];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)74)
		{
			float[] array27 = new float[-115];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)(-91))
		{
			float[] array28 = new float[-111];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)(-85))
		{
			float[] array29 = new float[-51];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == (filters)38)
		{
			float[] array30 = new float[-72];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
	}

	private void KPBEDPFEKFI()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[52];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)(-85))
		{
			PLKFKNHPEHE = new float[1] { 80f };
		}
		if (filterchoice == (filters)109)
		{
			float[] array2 = new float[-96];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == (filters)(-76))
		{
			float[] array3 = new float[104];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)(-54))
		{
			float[] array4 = new float[37];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)(-18))
		{
			float[] array5 = new float[-98];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)70)
		{
			float[] array6 = new float[74];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)53)
		{
			float[] array7 = new float[104];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)(-58))
		{
			float[] array8 = new float[-91];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array9 = new float[46];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array10 = new float[-74];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array11 = new float[-26];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array12 = new float[-80];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array13 = new float[94];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array14 = new float[85];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.Normal)
		{
			float[] array15 = new float[-82];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array16 = new float[125];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == (filters)(-35))
		{
			float[] array17 = new float[44];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)116)
		{
			float[] array18 = new float[-90];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)71)
		{
			float[] array19 = new float[-58];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)(-72))
		{
			float[] array20 = new float[-59];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)93)
		{
			float[] array21 = new float[-94];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)(-99))
		{
			float[] array22 = new float[-22];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)(-107))
		{
			float[] array23 = new float[117];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)40)
		{
			float[] array24 = new float[45];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)(-57))
		{
			float[] array25 = new float[84];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)(-111))
		{
			float[] array26 = new float[28];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)(-103))
		{
			float[] array27 = new float[-120];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)113)
		{
			float[] array28 = new float[-83];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)(-92))
		{
			float[] array29 = new float[-63];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == (filters)(-84))
		{
			float[] array30 = new float[-114];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
		if (filterchoice == (filters)(-96))
		{
			float[] array31 = new float[-125];
			RuntimeHelpers.InitializeArray(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array31;
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 424f)
			{
				HBJJOCHGOPH = 1478f;
			}
			BFGNMFCNDBC().SetFloat("_Value5", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Far", PLKFKNHPEHE[1] / 1892f);
			FAIFBBGFAIB().SetFloat("Preparing content", PLKFKNHPEHE[0] / 820f);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/FX_superDot", PLKFKNHPEHE[0] / 1650f);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", PLKFKNHPEHE[3] / 24f);
			BFGNMFCNDBC().SetFloat("ICollection", PLKFKNHPEHE[2] / 494f);
			PDEAHJPOMEF().SetFloat("_Value4", PLKFKNHPEHE[4] / 1927f);
			HFBJAOFLCJI().SetFloat("_NeighborMaxTex", PLKFKNHPEHE[3] / 245f);
			BFGNMFCNDBC().SetFloat(".sav", PLKFKNHPEHE[1] / 759f);
			HFBJAOFLCJI().SetFloat(": ", PLKFKNHPEHE[2] / 674f);
			HFBJAOFLCJI().SetFloat("_PColor", PLKFKNHPEHE[37] / 1139f);
			NBPKMLMCHFN.SetFloat("_Far", PLKFKNHPEHE[18] / 222f);
			FAIFBBGFAIB().SetFloat("Case-Sensitive", PLKFKNHPEHE[-10] / 1134f);
			HKGAONMOBMH().SetFloat("VisionBlur", FadeFX);
			PDEAHJPOMEF().SetVector("Forward", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 551f, 296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			if (HBJJOCHGOPH > 1100f)
			{
				HBJJOCHGOPH = 945f;
			}
			PGPEMMBJOOG().SetFloat("/?player=", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("note.7", PLKFKNHPEHE[0] / 1721f);
			NBPKMLMCHFN.SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", PLKFKNHPEHE[0] / 1932f);
			NBPKMLMCHFN.SetFloat("_PColor", PLKFKNHPEHE[2] / 325f);
			PGPEMMBJOOG().SetFloat("1", PLKFKNHPEHE[7] / 218f);
			PDEAHJPOMEF().SetFloat("_FixDistance", PLKFKNHPEHE[3] / 637f);
			NBPKMLMCHFN.SetFloat(" x ", PLKFKNHPEHE[0] / 1293f);
			HFBJAOFLCJI().SetFloat("restrictions", PLKFKNHPEHE[3] / 1881f);
			BFGNMFCNDBC().SetFloat("#ok", PLKFKNHPEHE[4] / 32f);
			NBPKMLMCHFN.SetFloat("_SizeY", PLKFKNHPEHE[5] / 1370f);
			HFBJAOFLCJI().SetFloat("_SunColor", PLKFKNHPEHE[-116] / 1876f);
			NBPKMLMCHFN.SetFloat("(\\[ *i *\\])", PLKFKNHPEHE[-74] / 495f);
			HFBJAOFLCJI().SetFloat("_TimeX", PLKFKNHPEHE[-64] / 1471f);
			NBPKMLMCHFN.SetFloat("_Value3", FadeFX);
			PGPEMMBJOOG().SetVector("_GlowColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1032f, 1359f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NIPKMFJEACH()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[97];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == (filters)74)
		{
			float[] array2 = new float[-55];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == filters.Blindness_Deuteranopia)
		{
			float[] array3 = new float[114];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)(-112))
		{
			float[] array4 = new float[-83];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)58)
		{
			float[] array5 = new float[-71];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)56)
		{
			float[] array6 = new float[-60];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)83)
		{
			float[] array7 = new float[-21];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)(-80))
		{
			float[] array8 = new float[110];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == (filters)(-56))
		{
			float[] array9 = new float[57];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array10 = new float[113];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array11 = new float[94];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.NashVille)
		{
			float[] array12 = new float[-28];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.PopRocket)
		{
			float[] array13 = new float[-122];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.BlueMoon)
		{
			float[] array14 = new float[39];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array15 = new float[45];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array16 = new float[80];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == filters.RedWhite)
		{
			float[] array17 = new float[-4];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array18 = new float[71];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)36)
		{
			float[] array19 = new float[-40];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)(-46))
		{
			float[] array20 = new float[21];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)83)
		{
			float[] array21 = new float[-66];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == (filters)(-96))
		{
			float[] array22 = new float[122];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)93)
		{
			float[] array23 = new float[25];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)(-54))
		{
			float[] array24 = new float[114];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)42)
		{
			float[] array25 = new float[109];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)(-31))
		{
			float[] array26 = new float[67];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)(-106))
		{
			float[] array27 = new float[-109];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)(-110))
		{
			float[] array28 = new float[-25];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)(-12))
		{
			float[] array29 = new float[-51];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == (filters)66)
		{
			float[] array30 = new float[78];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
		if (filterchoice == (filters)(-51))
		{
			float[] array31 = new float[56];
			RuntimeHelpers.InitializeArray(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array31;
		}
		if (filterchoice == (filters)91)
		{
			float[] array32 = new float[-91];
			RuntimeHelpers.InitializeArray(array32, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array32;
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_Red_R", PLKFKNHPEHE[0] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_G", PLKFKNHPEHE[1] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_B", PLKFKNHPEHE[2] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_R", PLKFKNHPEHE[3] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_G", PLKFKNHPEHE[4] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_B", PLKFKNHPEHE[5] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_R", PLKFKNHPEHE[6] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_G", PLKFKNHPEHE[7] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_B", PLKFKNHPEHE[8] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_C", PLKFKNHPEHE[9] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_C", PLKFKNHPEHE[10] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_C", PLKFKNHPEHE[11] / 100f);
			NBPKMLMCHFN.SetFloat("_FadeFX", FadeFX);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MLAGEPNCCGM()
	{
		MIPGPMKJELI();
	}

	private void KMCPMOGKDEH()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1183f)
			{
				HBJJOCHGOPH = 1284f;
			}
			HKGAONMOBMH().SetFloat("[ERROR KEY {0}]", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_TimeX", PLKFKNHPEHE[1] / 1119f);
			PDEAHJPOMEF().SetFloat("_Max", PLKFKNHPEHE[1] / 875f);
			BFGNMFCNDBC().SetFloat("Joystick1Button12", PLKFKNHPEHE[4] / 1146f);
			FAIFBBGFAIB().SetFloat("MenuVolumeSlider", PLKFKNHPEHE[8] / 1976f);
			HFBJAOFLCJI().SetFloat("offsets", PLKFKNHPEHE[8] / 1917f);
			NBPKMLMCHFN.SetFloat("BloodAlternative3", PLKFKNHPEHE[0] / 106f);
			HFBJAOFLCJI().SetFloat("steamid", PLKFKNHPEHE[7] / 1584f);
			FAIFBBGFAIB().SetFloat("player.bat", PLKFKNHPEHE[8] / 979f);
			HKGAONMOBMH().SetFloat("_Value3", PLKFKNHPEHE[4] / 834f);
			FAIFBBGFAIB().SetFloat("effector", PLKFKNHPEHE[80] / 1706f);
			PDEAHJPOMEF().SetFloat("note.6", PLKFKNHPEHE[-89] / 712f);
			HKGAONMOBMH().SetFloat("_ReflectionBlur", PLKFKNHPEHE[93] / 196f);
			PDEAHJPOMEF().SetFloat("Set Sun DirectionVector", FadeFX);
			PGPEMMBJOOG().SetVector("_Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 887f, 348f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHLMNAGPKDA()
	{
		POPFEPMJDPF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void FHGKIOOMMOH()
	{
		HEDFBCFGDLF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GPNAOAKCMHC()
	{
		POPFEPMJDPF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1215f)
			{
				HBJJOCHGOPH = 1080f;
			}
			FAIFBBGFAIB().SetFloat("CameraFilterPack/3D_Binary", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("z", PLKFKNHPEHE[0] / 1978f);
			NBPKMLMCHFN.SetFloat("menuthemes", PLKFKNHPEHE[1] / 1612f);
			PDEAHJPOMEF().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", PLKFKNHPEHE[3] / 771f);
			BFGNMFCNDBC().SetFloat("OxOD.lastPath", PLKFKNHPEHE[5] / 349f);
			HKGAONMOBMH().SetFloat("_Fade", PLKFKNHPEHE[7] / 1717f);
			PGPEMMBJOOG().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", PLKFKNHPEHE[1] / 333f);
			PGPEMMBJOOG().SetFloat("ViewID {0} {1}{2}", PLKFKNHPEHE[7] / 116f);
			PDEAHJPOMEF().SetFloat("#join", PLKFKNHPEHE[7] / 544f);
			PGPEMMBJOOG().SetFloat("A", PLKFKNHPEHE[8] / 1434f);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", PLKFKNHPEHE[-8] / 845f);
			HFBJAOFLCJI().SetFloat("_TimeX", PLKFKNHPEHE[-61] / 512f);
			BFGNMFCNDBC().SetFloat("EnableRankingToggle", PLKFKNHPEHE[-5] / 251f);
			PDEAHJPOMEF().SetFloat("ExitButton", FadeFX);
			HKGAONMOBMH().SetVector("_ChromaticAberration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 512f, 843f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHNCEEDIKCC()
	{
		if (filterchoice == filters.Normal)
		{
			float[] array = new float[-3];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array;
		}
		if (filterchoice == filters.GoldenPink)
		{
			float[] array2 = new float[-38];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array2;
		}
		if (filterchoice == filters.BlueJeans)
		{
			float[] array3 = new float[-85];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array3;
		}
		if (filterchoice == (filters)(-119))
		{
			float[] array4 = new float[-13];
			RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array4;
		}
		if (filterchoice == (filters)46)
		{
			float[] array5 = new float[-65];
			RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array5;
		}
		if (filterchoice == (filters)(-42))
		{
			float[] array6 = new float[94];
			RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array6;
		}
		if (filterchoice == (filters)(-71))
		{
			float[] array7 = new float[98];
			RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array7;
		}
		if (filterchoice == (filters)67)
		{
			float[] array8 = new float[45];
			RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array8;
		}
		if (filterchoice == (filters)(-33))
		{
			float[] array9 = new float[-14];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array9;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array10 = new float[85];
			RuntimeHelpers.InitializeArray(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array10;
		}
		if (filterchoice == filters.BlueLagoon)
		{
			float[] array11 = new float[-118];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array11;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array12 = new float[-18];
			RuntimeHelpers.InitializeArray(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array12;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array13 = new float[106];
			RuntimeHelpers.InitializeArray(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array13;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array14 = new float[68];
			RuntimeHelpers.InitializeArray(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array14;
		}
		if (filterchoice == filters.DarkPink)
		{
			float[] array15 = new float[-121];
			RuntimeHelpers.InitializeArray(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array15;
		}
		if (filterchoice == filters.RedWhite)
		{
			float[] array16 = new float[-87];
			RuntimeHelpers.InitializeArray(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array16;
		}
		if (filterchoice == filters.VintageYellow)
		{
			float[] array17 = new float[-106];
			RuntimeHelpers.InitializeArray(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array17;
		}
		if (filterchoice == (filters)80)
		{
			float[] array18 = new float[70];
			RuntimeHelpers.InitializeArray(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array18;
		}
		if (filterchoice == (filters)(-40))
		{
			float[] array19 = new float[-96];
			RuntimeHelpers.InitializeArray(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array19;
		}
		if (filterchoice == (filters)78)
		{
			float[] array20 = new float[-17];
			RuntimeHelpers.InitializeArray(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array20;
		}
		if (filterchoice == (filters)(-45))
		{
			float[] array21 = new float[-125];
			RuntimeHelpers.InitializeArray(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array21;
		}
		if (filterchoice == filters.BlackAndWhite_Green)
		{
			float[] array22 = new float[-38];
			RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array22;
		}
		if (filterchoice == (filters)(-99))
		{
			float[] array23 = new float[-68];
			RuntimeHelpers.InitializeArray(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array23;
		}
		if (filterchoice == (filters)(-60))
		{
			float[] array24 = new float[-43];
			RuntimeHelpers.InitializeArray(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array24;
		}
		if (filterchoice == (filters)(-93))
		{
			float[] array25 = new float[-93];
			RuntimeHelpers.InitializeArray(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array25;
		}
		if (filterchoice == (filters)62)
		{
			float[] array26 = new float[-51];
			RuntimeHelpers.InitializeArray(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array26;
		}
		if (filterchoice == (filters)(-45))
		{
			float[] array27 = new float[-46];
			RuntimeHelpers.InitializeArray(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array27;
		}
		if (filterchoice == (filters)61)
		{
			float[] array28 = new float[125];
			RuntimeHelpers.InitializeArray(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array28;
		}
		if (filterchoice == (filters)91)
		{
			float[] array29 = new float[-17];
			RuntimeHelpers.InitializeArray(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array29;
		}
		if (filterchoice == filters.YellowSunSet)
		{
			float[] array30 = new float[73];
			RuntimeHelpers.InitializeArray(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array30;
		}
		if (filterchoice == (filters)82)
		{
			float[] array31 = new float[104];
			RuntimeHelpers.InitializeArray(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array31;
		}
		if (filterchoice == (filters)37)
		{
			float[] array32 = new float[-66];
			RuntimeHelpers.InitializeArray(array32, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			PLKFKNHPEHE = array32;
		}
	}

	private void KNBJBNDGCIJ()
	{
		NIPKMFJEACH();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		LBEHKFNPKMC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
