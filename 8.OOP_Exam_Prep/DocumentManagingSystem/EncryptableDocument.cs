using System;

namespace DocumentManagingSystem
{
    public abstract class EncryptableDocument : BinaryDocument, IEncryptable
    {
        public bool IsEncrypted { get; private set; }

        protected EncryptableDocument(string name)
            : base(name)
        {
        }

        public virtual void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public virtual void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                return string.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
