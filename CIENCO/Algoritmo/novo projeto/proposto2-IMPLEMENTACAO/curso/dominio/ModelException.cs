using System;

namespace curso.dominio {
    class ModelException : Exception {
        public ModelException(string msg) : base(msg) {
        }
    }
}
