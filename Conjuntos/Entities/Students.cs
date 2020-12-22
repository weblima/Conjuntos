namespace Conjuntos.Entities {
    class Students {
        public string Course { get; set; }
        public int Usuario { get; set; }

        public override int GetHashCode() {
            return Usuario.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is Students)) {
                return false;
            }

            Students other = obj as Students;
            return Usuario.Equals(other.Usuario);
        }
    }
}
