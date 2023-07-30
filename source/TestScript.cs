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

	public void HNLPMDDFFHM()
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

	public void NDDFGJOMJFP()
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

	public void HEKMGMMLICN()
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

	public void MGANMCDBGFN()
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

	public void GGILOOBKOLL()
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

	public void IOEADPNJIGN()
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

	public void KJGAJIOLLJE()
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

	public void ECFBAGMLBOF()
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

	public void MJPMLLOEAFE()
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

	public void CEBEHMNPLMC()
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

	public void PKEFFAMKIML()
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

	public void FFJAGGLEJKP()
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

	public void CKFGOOLBOOG()
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

	public void DNLGIABPDEG()
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

	public void KFFPFEFMEIJ()
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

	public void EMGMHNMFEFE()
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

	public void CFEIKBBBBAG()
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

	public void FABFEMLDDHP()
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

	public void NNMBDMLHFDF()
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

	public void AFBDFFGCDEC()
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

	public void NDBOLDIJMJH()
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

	public void NOCAPPFKLHO()
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

	public void GOHFAIPDCIC()
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

	public void LMDPAIIEFPD()
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

	public void ACAADNOADNE()
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

	public void LCFNACOFILF()
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

	public void POMIDPILOOP()
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

	public void GCJJPHONNIP()
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

	public void PHPKGFBIPHB()
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

	public void JEECDLPODCB()
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

	public void AOOALOMNDIH()
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

	public void EBKBIPKFLLL()
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

	public void ICMDKJIPAGG()
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

	public void CBCDNHIFJFD()
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

	public void CHPHHOJBBKD()
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

	public void KKBDHGFLNAI()
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

	public void JLBCDNPOBMF()
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

	public void OKNILJBNKLI()
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

	public void JNKMGCALJID()
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

	public void FJHKIOGGIKC()
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

	public void DJJHMEBFMFA()
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

	public void LBFEAHKJCNL()
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

	public void HOICOKEAAMN()
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

	public void FIKLCHAJGMD()
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

	public void FBOECKEKANJ()
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

	public void HMCJMDFDIBL()
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

	public void ICCNKNBNKLF()
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

	public void KKIMNOLMLMO()
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

	public void DECLDDOMAHF()
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

	public void CMHAMGGBCFI()
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

	public void GKOKDHJFLPM()
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

	public void HBPFAIKDKHL()
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

	public void GAGEHOJFBPK()
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

	public void GALACIFCLND()
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

	public void BGJDEIOOMGO()
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

	public void KMFFCODEPKF()
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

	public void DEJHNEAEDPN()
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

	public void GDHHEBDEJJA()
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

	public void ONNLFLEFNAP()
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

	public void FPEAGILFFBM()
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

	public void OFGONAHPJLA()
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

	public void FDGLOBAFBCI()
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

	public void BHEHJAEGEEA()
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

	public void JNBJKONDFDO()
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

	public void BPKMALONNDI()
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

	public void EMJDOHOICOF()
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
}
