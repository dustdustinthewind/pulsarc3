// AuthenticationValues
using System;
using System.Runtime.CompilerServices;

public class AuthenticationValues
{
	private CustomAuthenticationType EJBNALIEBFH = CustomAuthenticationType.None;

	public CustomAuthenticationType AuthType
	{
		get
		{
			return EJBNALIEBFH;
		}
		set
		{
			EJBNALIEBFH = value;
		}
	}

	public string AuthGetParameters { get; set; }

	public object AuthPostData { get; private set; }

	public string Token { get; set; }

	public string UserId { get; set; }

	[SpecialName]
	private void JFDHMIGNFAL(object DPNHODJHGJL)
	{
		_003CKKLGJFDHKIJ_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void AddAuthParameter(string HFEFHOPOLIK, string DPNHODJHGJL)
	{
		string text = ((!string.IsNullOrEmpty(AuthGetParameters)) ? "&" : string.Empty);
		AuthGetParameters = $"{AuthGetParameters}{text}{Uri.EscapeDataString(HFEFHOPOLIK)}={Uri.EscapeDataString(DPNHODJHGJL)}";
	}

	public virtual void AFDLFNGEEOF(byte[] HNCGEEOBGGO)
	{
		GHEBBKIENKD(HNCGEEOBGGO);
	}

	public override string HNHNKFEAAKA()
	{
		return string.Format("quantity", NEPEFCOOEGO(), OMCPFLLPIPM(), PPFIBJOHICJ() == null);
	}

	[SpecialName]
	public void AJBJIDHDDAB(string DPNHODJHGJL)
	{
		_003CDELIHEHNGKB_003Ek__BackingField = DPNHODJHGJL;
	}

	public AuthenticationValues()
	{
	}

	public override string EDFALDILGCL()
	{
		return string.Format("BitsData", NEPEFCOOEGO(), OMCPFLLPIPM(), PPFIBJOHICJ() == null);
	}

	[SpecialName]
	public string IFKGNPNPDDI()
	{
		return _003CFABPAJHAJCG_003Ek__BackingField;
	}

	[SpecialName]
	private void GHEBBKIENKD(object DPNHODJHGJL)
	{
		_003CKKLGJFDHKIJ_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void NLFHIBOHFGG(string MGJCBKGCFHA)
	{
		AuthPostData = ((!string.IsNullOrEmpty(MGJCBKGCFHA)) ? MGJCBKGCFHA : null);
	}

	[SpecialName]
	public void LJDKJPICAEI(string DPNHODJHGJL)
	{
		_003CJBOIDBBKGGI_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	private void BMFPDIEKHJA(object DPNHODJHGJL)
	{
		_003CKKLGJFDHKIJ_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void MCBJCDIEPME(string MGJCBKGCFHA)
	{
		AuthPostData = ((!string.IsNullOrEmpty(MGJCBKGCFHA)) ? MGJCBKGCFHA : null);
	}

	[SpecialName]
	public void JCECBNKFODG(string DPNHODJHGJL)
	{
		_003CDELIHEHNGKB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void FNCDLDJFJAM(string DPNHODJHGJL)
	{
		_003CFABPAJHAJCG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void MIHBPLHLFGG(string DPNHODJHGJL)
	{
		_003CDELIHEHNGKB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string OMCPFLLPIPM()
	{
		return _003CJBOIDBBKGGI_003Ek__BackingField;
	}

	[SpecialName]
	public string DGINDFBNNDO()
	{
		return _003CFABPAJHAJCG_003Ek__BackingField;
	}

	[SpecialName]
	public string PPFIBJOHICJ()
	{
		return _003CFABPAJHAJCG_003Ek__BackingField;
	}

	[SpecialName]
	public void NNIDGJOPJOI(string DPNHODJHGJL)
	{
		_003CFABPAJHAJCG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public CustomAuthenticationType NKIEPEALJIB()
	{
		return EJBNALIEBFH;
	}

	[SpecialName]
	public string NEPEFCOOEGO()
	{
		return _003CDELIHEHNGKB_003Ek__BackingField;
	}

	[SpecialName]
	public void BLJGPAAPBKN(string DPNHODJHGJL)
	{
		_003CJBOIDBBKGGI_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void SetAuthPostData(string MGJCBKGCFHA)
	{
		AuthPostData = ((!string.IsNullOrEmpty(MGJCBKGCFHA)) ? MGJCBKGCFHA : null);
	}

	[SpecialName]
	public void NJJEJBOAEDG(string DPNHODJHGJL)
	{
		_003CFABPAJHAJCG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void AMNGGOOHECA(string DPNHODJHGJL)
	{
		_003CJBOIDBBKGGI_003Ek__BackingField = DPNHODJHGJL;
	}

	public override string ToString()
	{
		return $"AuthenticationValues UserId: {UserId}, GetParameters: {AuthGetParameters} Token available: {Token != null}";
	}

	[SpecialName]
	public object LPMFOIPADGG()
	{
		return _003CKKLGJFDHKIJ_003Ek__BackingField;
	}

	public AuthenticationValues(string DJACMLGPOJB)
	{
		UserId = DJACMLGPOJB;
	}

	[SpecialName]
	public object MLKCIABICJB()
	{
		return _003CKKLGJFDHKIJ_003Ek__BackingField;
	}

	public virtual void MHDGFNJJLCM(byte[] HNCGEEOBGGO)
	{
		BMFPDIEKHJA(HNCGEEOBGGO);
	}

	[SpecialName]
	public void AIOHGAFEHJG(string DPNHODJHGJL)
	{
		_003CFABPAJHAJCG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void DHDAMKILAND(string DPNHODJHGJL)
	{
		_003CJBOIDBBKGGI_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void SetAuthPostData(byte[] HNCGEEOBGGO)
	{
		AuthPostData = HNCGEEOBGGO;
	}
}
