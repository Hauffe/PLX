using BusinessLayer.BO;
using BusinessLayer.DAO;
using BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Facades
{

        public class AvaliacaoFacade : BaseFacade
        {
            private AvaliacaoBO avaliacaoBo;
            private SqlServerDao dao;

            public AvaliacaoFacade()
            {
                dao = new SqlServerDao();
                avaliacaoBo = new AvaliacaoBO(dao);
            }

            public void SalvarCategoria(string nome, string descricao)
            {
                AvaliacaoDto c = new AvaliacaoDto();

                avaliacaoBo.SalvarAvaliacao(c);
            }
        }
}
