namespace Patern_SINGLETON
{
    public class Singleton
    {
        // <summary>
        /// Объект синхронизации, необходим для безопасности при многопоточном использовании.
        /// </summary>
        private static object _sync = new object();

        /// <summary>
        /// Основной объект, в котором будет храниться уникальный экземпляр класса. 
        /// </summary>
        private static Singleton _instance;

        /// <summary>
        /// Какие-либо хранимые данные.
        /// </summary>
        private string _data;

        /// <summary>
        /// Данные, используемые в классе.
        /// </summary>
        //private string Data => _data;
        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                lock (_sync) // Используется чтобы избежать одновременного доступа критической секции из разных потоков.
                {
                    _data = value;
                }
            }
        }

        /// <summary>
        /// Защищенный конструктор для инициализации единственного экземпляра класса.
        /// </summary>
        /// <param name="data">Данные, используемые в классе.</param>
        private Singleton(string data)
        {
            //_data = data;
            Data = data;
        }

        /// <summary>
        /// Получить экземпляр класса.
        /// </summary>
        /// <param name="data">Инициализирующие данные класса.</param>
        /// <returns>Уникальный экземпляр класса.</returns>
        public static Singleton GetInstance(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }
            
            lock (_sync) // Используется чтобы избежать одновременного доступа критической секции из разных потоков.
            {
                if (_instance == null)
                {
                    _instance = new Singleton(data);
                }
            }
            
            return _instance;
        }
        public override string ToString()
        {
            return Data;
        }
    }
}
