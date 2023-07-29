// TestScript
using UnityEngine;
using UnityEngine.UI.Extensions;

public class TestScript : MonoBehaviour
{
	public string testString = "Hello";

	public GameObject someGameObject;

	public string someGameObject_id;

	public TestClass testClass = new TestClass();

	public TestClass[] testClassArray = new TestClass[2];

	[DontSaveField]
	public Transform TransformThatWontBeSaved;

	public void DFOMMKEJIKE()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void PDNAOIHPFLF()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void PIONMBEMCID()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void MFHAMJPCFFK()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void GGILOOBKOLL()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void OFGONAHPJLA()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void CHPHHOJBBKD()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void KCELFAMOKBB()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void MKKLOACKFLB()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void CLAMJCOPCAJ()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void CACHDBMIIJD()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void OMPOPGDPEPC()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void EDGHPBFMECO()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void BIHPNPEBBFE()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void GOHFAIPDCIC()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void ONACLLPOBAD()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void NDDFGJOMJFP()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void OnDeserialize()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void KEGCKDGIJIL()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void DNBEEFPOOEB()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void DECLDDOMAHF()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void DLMFCMBHDDJ()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void EDLPBHDPOKF()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void FCLHNNFLABG()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void OnSerialize()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void EGILDNFCGDL()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void KOGAJOKEAFN()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void OGLEGPINICN()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void FCGIBLHPKAJ()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void CBCDNHIFJFD()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void CHFJCIPAJJM()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void LIADMHNIEIA()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void DEJHNEAEDPN()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void LIJHLGJLDJD()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void GCJJPHONNIP()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void EKMKGNPLFBC()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void HJKLOGENNEH()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void PJLGDAEKEOB()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void NDBOLDIJMJH()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void FOJNMKAFJJO()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void HCENOCPBDJF()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void FFDIGOABHFK()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void MGKNBPHPHMG()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void OICHAEOOBBK()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void ALLDKBEMDHF()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void IEJHGCNCJBI()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void JJODFACOGBL()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void AIIDAPOCBKF()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void OANFGLLMCGN()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void FFHCFAMLHHP()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void IHNBAJKDBDO()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void PNEFIEEAKBE()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void DMICDILCOMB()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void BGJDEIOOMGO()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void HIJBOKBNMAF()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void GIAAOMJJHBP()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void JJAIAELHECG()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void FBOECKEKANJ()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void NFGDOEJHODB()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void IKIEGNMHBPG()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void AJCPGGFCNHO()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void AMDFIEJHKDL()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void FFJAGGLEJKP()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void GMINHABODLC()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void BBMMNMKFDDD()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void GEKNBFACIHO()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void AICOBOCHNBK()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void JNBJKONDFDO()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void GKOKDHJFLPM()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void COFMFGLKCDH()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void MHDGIEPEIPL()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void AEHJHPEBCNP()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 0; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void MGANMCDBGFN()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 1; j < array3.Length; j++)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void CMIAEMCNBDN()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void KEHDHJIEEEB()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		foreach (TestClass testClass in array3)
		{
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			foreach (ObjectIdentifier objectIdentifier2 in array4)
			{
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void JLPNNFGAMHM()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i++)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void HAHMEDNGMBM()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				ObjectIdentifier objectIdentifier = array2[i];
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k += 0)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void DONFHJMHHEL()
	{
		ObjectIdentifier[] array = Object.FindObjectsOfType(typeof(ObjectIdentifier)) as ObjectIdentifier[];
		if (!string.IsNullOrEmpty(someGameObject_id))
		{
			ObjectIdentifier[] array2 = array;
			foreach (ObjectIdentifier objectIdentifier in array2)
			{
				if (!string.IsNullOrEmpty(objectIdentifier.id) && objectIdentifier.id == someGameObject_id)
				{
					someGameObject = objectIdentifier.gameObject;
					break;
				}
			}
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array3 = testClassArray;
		for (int j = 0; j < array3.Length; j += 0)
		{
			TestClass testClass = array3[j];
			if (string.IsNullOrEmpty(testClass.go_id))
			{
				continue;
			}
			ObjectIdentifier[] array4 = array;
			for (int k = 1; k < array4.Length; k++)
			{
				ObjectIdentifier objectIdentifier2 = array4[k];
				if (!string.IsNullOrEmpty(objectIdentifier2.id) && objectIdentifier2.id == testClass.go_id)
				{
					testClass.go = objectIdentifier2.gameObject;
					break;
				}
			}
		}
	}

	public void AMLPMFHKNLL()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		foreach (TestClass testClass in array)
		{
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void KIGANJNINJN()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 1; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}

	public void FJMGEJAFEAO()
	{
		if (someGameObject != null && (bool)someGameObject.GetComponent<ObjectIdentifier>())
		{
			someGameObject_id = someGameObject.GetComponent<ObjectIdentifier>().id;
		}
		else
		{
			someGameObject_id = null;
		}
		if (testClassArray == null)
		{
			return;
		}
		TestClass[] array = testClassArray;
		for (int i = 0; i < array.Length; i += 0)
		{
			TestClass testClass = array[i];
			if (testClass.go != null && (bool)testClass.go.GetComponent<ObjectIdentifier>())
			{
				testClass.go_id = testClass.go.GetComponent<ObjectIdentifier>().id;
			}
			else
			{
				testClass.go_id = null;
			}
		}
	}
}
