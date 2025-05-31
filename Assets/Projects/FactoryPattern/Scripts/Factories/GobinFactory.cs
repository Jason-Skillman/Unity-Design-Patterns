namespace FactoryPattern.Factories
{
	using FactoryPattern.AIBots;
	using UnityEngine;

	public class GobinFactory : IFactory
	{
		public Enemy Create(GameObject prefab)
		{
			GameObject gameObject = Object.Instantiate(prefab);
			Gobin goblin = gameObject.AddComponent<Gobin>();

			//Setup logic here...
			gameObject.name = "Goblin";
			
			int gold = Random.Range(1, 10);
			goblin.Initialize(gold);
			
			return goblin;
		}
	}
}
