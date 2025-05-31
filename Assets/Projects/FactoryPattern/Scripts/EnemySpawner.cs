namespace FactoryPattern
{
	using FactoryPattern.AIBots;
	using FactoryPattern.Factories;
	using UnityEngine;

	public class EnemySpawner : MonoBehaviour
	{
		[SerializeField]
		private GameObject enemyBasePrefab;
		
		/// <summary>
		/// This factory can easily be switched out for another factory.
		/// </summary>
		private IFactory factory = new OrcFactory();

		private void Start()
		{
			Spawn();
		}

		private void Spawn()
		{
			Enemy enemy = factory.Create(enemyBasePrefab);
			enemy.Speak();
		}
	}
}
