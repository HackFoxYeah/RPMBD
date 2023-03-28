namespace kapustinRPMBD
{
    using System.Data.Entity;
    public partial class AeroflotInfoEntities : DbContext
    {
        /// <summary>
        /// Статичная ссылка на контекст.
        /// </summary>
        private static AeroflotInfoEntities _context;

        /// <summary>
        /// Получение конекста.
        /// </summary>
        /// <returns>Контекст</returns>
        public static AeroflotInfoEntities GetContext()
        {
            if (_context == null)
                _context = new AeroflotInfoEntities();
            return _context;
        }
    }
}