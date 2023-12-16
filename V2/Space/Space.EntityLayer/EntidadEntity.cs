using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Space.EntityLayer
{
    public partial class EntidadEntity  : Utilitario
    {
		private Int32 m_EntidadId;
		private Int32? m_TipoEntidadId;
		private Boolean m_EsEmpresa;
		private Int32? m_TipoDocumentoIdentidadId;
		private String m_NumDocumento;
		private String m_NombreCompleto;
		private DateTime m_FechaRegistro;
		private String m_CodUsuario;
		private Int32? m_UbigeoId;
		

        public EntidadEntity()
            : base()
        {
			m_EntidadId = GetInt32Default();
			m_TipoEntidadId = null;
			m_EsEmpresa = GetBooleanDefault();
			m_TipoDocumentoIdentidadId = null;
			m_NumDocumento = GetStringDefault();
			m_NombreCompleto = GetStringDefault();
			m_FechaRegistro = GetDateTimeDefault();
			m_CodUsuario = GetStringDefault();
			m_UbigeoId = null;
        }

		public Int32 EntidadId
		{
			get { return m_EntidadId; }
			set
			{
				Int32 oldValue = m_EntidadId;
				if (oldValue == value) return;
				m_EntidadId = value;
			}
		}
		public Int32? TipoEntidadId
		{
			get { return m_TipoEntidadId; }
			set
			{
				Int32? oldValue = m_TipoEntidadId;
				if (oldValue == value) return;
				m_TipoEntidadId = value;
			}
		}
		public Boolean EsEmpresa
		{
			get { return m_EsEmpresa; }
			set
			{
				Boolean oldValue = m_EsEmpresa;
				if (oldValue == value) return;
				m_EsEmpresa = value;
			}
		}
		public Int32? TipoDocumentoIdentidadId
		{
			get { return m_TipoDocumentoIdentidadId; }
			set
			{
				Int32? oldValue = m_TipoDocumentoIdentidadId;
				if (oldValue == value) return;
				m_TipoDocumentoIdentidadId = value;
			}
		}
		public String NumDocumento
		{
			get { return m_NumDocumento; }
			set
			{
				String oldValue = m_NumDocumento;
				if (oldValue == value) return;
				m_NumDocumento = value;
			}
		}
		public String NombreCompleto
		{
			get { return m_NombreCompleto; }
			set
			{
				String oldValue = m_NombreCompleto;
				if (oldValue == value) return;
				m_NombreCompleto = value;
			}
		}
		public DateTime FechaRegistro
		{
			get { return m_FechaRegistro; }
			set
			{
				DateTime oldValue = m_FechaRegistro;
				if (oldValue == value) return;
				m_FechaRegistro = value;
			}
		}
		public String CodUsuario
		{
			get { return m_CodUsuario; }
			set
			{
				String oldValue = m_CodUsuario;
				if (oldValue == value) return;
				m_CodUsuario = value;
			}
		}
		public Int32? UbigeoId
		{
			get { return m_UbigeoId; }
			set
			{
				Int32? oldValue = m_UbigeoId;
				if (oldValue == value) return;
				m_UbigeoId = value;
			}
		}
       
		
    }
}

