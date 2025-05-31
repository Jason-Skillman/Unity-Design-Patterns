namespace FactoryPattern.Factories
{
	using FactoryPattern.AIBots;
	using UnityEngine;

	public class OrcFactory : IFactory
	{
		public Enemy Create(GameObject prefab)
		{
			GameObject gameObject = Object.Instantiate(prefab);
			Orc orc = gameObject.AddComponent<Orc>();
			
			//Setup logic here...
			gameObject.name = "Orc";

			float attack = Random.Range(10.0f, 20.0f);
			orc.Initialize(attack);
			
			return orc;
		}
	}
}
