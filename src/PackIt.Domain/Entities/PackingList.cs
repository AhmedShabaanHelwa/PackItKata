using System;

namespace PackIt.Domain.Entities
{
    /// <summary>
    /// List of the stuff to be packed
    /// </summary>
    internal class PackingList
    {
        private string _name;
        private string _localization;
        public Guid Id { get; private set; }
        
        public PackingList(string name, string localization)
        => (this._name, this._localization) = (name, localization);
    }
}
