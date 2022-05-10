using System;

namespace PackIt.Domain.Entities
{
    /// <summary>
    /// List of the stuff to be packed
    /// </summary>
    internal class PackingList
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Localization { get; private set; }

        public PackingList(string name, string localization)
        => (this.Name, this.Localization) = (name, localization);
    }
}
