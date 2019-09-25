using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaCarros.Model
{
    class VendaContext
    {
        public VendaContext()
        {
            public class PessoaController
        {
            /// <summary>
            /// Lista que contem as pessoas para realizar as atividades
            /// </summary>
            private List<Pessoa> listaDePessoas { get; set; }
            /// <summary>
            /// O metodo construtor ajuda a iniciar nossa classe para utilizarmos
            /// de maneira correta as informações internas, com isso podemos iniciar
            /// nossa lista de pessoas sem depender do usuario ou programador na parte da interface
            /// </summary>
            public PessoaController()
            {
                //Iniciamos a lista de pessoas dentro do nosso metodo construtor
                listaDePessoas = new List<Pessoa>();

                listaDeCarros.Add(new Carro() { Id = 1, Nome = "Spears  ", DataNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
                listaDePessoas.Add(new Pessoa() { Id = 2, Nome = "Swanson  ", DataNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
                listaDePessoas.Add(new Pessoa() { Id = 3, Nome = "Gay      ", DataNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
                listaDePessoas.Add(new Pessoa() { Id = 4, Nome = "Gregory  ", DataNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
                listaDePessoas.Add(new Pessoa() { Id = 5, Nome = "Olson    ", DataNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
                listaDePessoas.Add(new Pessoa() { Id = 6, Nome = "Garza    ", DataNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
                listaDePessoas.Add(new Pessoa() { Id = 7, Nome = "Sweet    ", DataNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
                listaDePessoas.Add(new Pessoa() { Id = 8, Nome = "Cline    ", DataNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
                listaDePessoas.Add(new Pessoa() { Id = 9, Nome = "Oliver   ", DataNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
                listaDePessoas.Add(new Pessoa() { Id = 10, Nome = "Vang     ", DataNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
                listaDePessoas.Add(new Pessoa() { Id = 11, Nome = "Maddox   ", DataNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
                listaDePessoas.Add(new Pessoa() { Id = 12, Nome = "Garrett  ", DataNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
                listaDePessoas.Add(new Pessoa() { Id = 13, Nome = "Mcintosh ", DataNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
                listaDePessoas.Add(new Pessoa() { Id = 14, Nome = "Yang     ", DataNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
                listaDePessoas.Add(new Pessoa() { Id = 15, Nome = "Hendricks", DataNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
                listaDePessoas.Add(new Pessoa() { Id = 16, Nome = "Cain     ", DataNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
                listaDePessoas.Add(new Pessoa() { Id = 17, Nome = "Blackburn", DataNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
                listaDePessoas.Add(new Pessoa() { Id = 18, Nome = "Howe     ", DataNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
                listaDePessoas.Add(new Pessoa() { Id = 19, Nome = "Pratt    ", DataNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
                listaDePessoas.Add(new Pessoa() { Id = 20, Nome = "Sherman  ", DataNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });

            }




            listaDeCarros = new List<Carro>();

            listaDeCarros.Add(new Carro() { Id = 1, Nome = "Risus Company", Quantidade = 7, Valor = 2000.18, Data = "29/01/2019" });
            listaDeCarros.Add(new Carro() { Id = 1, Nome = " Risus Company",   Valor = 7.200, Quantidade = 18,  Data = "29/01/2019" });








            //listaDeCarros.Add(new Carro() { Id = 2  ,  Nome = "Risus Associates              " ,   Valor = 8.710 Quantidade = 17  Data = "24/01/2019"});
            //Id = 4  ,  Nome = "Cursus Et Ltd                 "    9.010 Quantidade = 17  Data = "26/10/2019"          });
            //Id = 5  ,  Nome = "Odio Etiam Ligula Company      "    5.245 Quantidade = 8   Data = "16/02/2019"         });
            //Id = 6  ,  Nome = "Eu Nibh Inc.                   "    7.922 Quantidade = 9   Data = "27/06/2019"         });
            //Id = 7  ,  Nome = "Tellus Limited                  "    7.294 Quantidade = 7   Data = "26/01/2019"        });
            //Id = 8  ,  Nome = "Imperdiet PC                   "    8.305 Quantidade = 5   Data = "06/09/2019"         });
            //Id = 9  ,  Nome = "Elit Inc.                      "    5.398 Quantidade = 18  Data = "09/06/2019"         });
            //Id = 10 ,  Nome = "Quam A Limited"                  "    5.398 Quantidade = 14  Data = "09/09/2019"       });
            //Id = 11 ,  Nome = "Adipiscing Institute            "    8.133 Quantidade = 4   Data = "24/10/2019"        });
            //Id = 12 ,  Nome = "Posuere At Velit Ltd            "    5.121 Quantidade = 15  Data = "19/11/2019"        });
            //Id = 13 ,  Nome = "Nunc In Industries"              "    8.902 Quantidade = 2   Data = "21/07/2019"       });
            //Id = 14 ,  Nome = "Integer Vitae Nibh Corporation  "    6.313 Quantidade = 20  Data = "02/02/2019"        });
            //Id = 15 ,  Nome = "Tellus Nunc Lectus Company"      "    9.650 Quantidade = 2   Data = "20/07/2019"       });
            //Id = 16 ,  Nome = "Suspendisse LLC"                 "    5.319 Quantidade = 12  Data = "24/12/2019"       });
            //Id = 17 ,  Nome = "Mauris Vestibulum Corporation  "    5.790 Quantidade = 5   Data = "14/11/2019"         });
            //Id = 18 ,  Nome = "Sed Nec Corp.                  "  8.421  2   05/05/2019                                });
            //Id = 19 ,  Nome = "Enim Nisl Elementum Inc.         "     5.904  6   26/06/2019                           });
            //Id = 20 ,  Nome = "Ac Mattis Semper Corporation     "               5.110  4   14/01/2019                 });
            //Id = 21 ,  Nome = "Donec Tempus Lorem LLC           "    8.576  16  29/03/2019                            });
            //Id = 22 ,  Nome = "Tempor Augue Ac Ltd              "    9.072  16  09/07/2019                            });
            //Id = 23 ,  Nome = "Diam Duis Mi LLC                 "   8.472  4   23/09/2019                             });
            //Id = 24 ,  Nome = "Aliquam Corp.                    "     6.607  4   28/09/2019                           });
            //Id = 25 ,  Nome = "Montes Institute                 "  6.176  8   19/06/2019                              });
            //Id = 26 ,  Nome = "Hendrerit Institute              "  8.387  11  17/09/2019                              });
            //Id = 27 ,  Nome = "Erat Etiam Vestibulum Corporation"                 7.584  9   02/06/2019               });
            //Id = 28 ,  Nome = "Adipiscing Ltd                          7.887  9   19/03/2019                          });
            //Id = 29 ,  Nome = "In Tempus Eu Inc.                      5.233  16  20/07/2019                           });
            //Id = 30 ,  Nome = "Elit Institute                     7.359  11  12/09/2019                               });
            //Id = 31 ,  Nome = "Aliquam Erat LLC                          8.842  4   14/03/2019                        });
            //Id = 32 ,  Nome = "A Feugiat Tellus PC                    9.176  4   10/12/2019                           });
            //Id = 33 ,  Nome = "Aliquet Incorporated                    9.057  8   26/04/2019                          });
            //Id = 34 ,  Nome = "Dolor Dolor Tempus Institute                   8.433  15  31/10/2019                   });
            //Id = 35 ,  Nome = "Risus Odio Auctor PC                     8.286  11  29/03/2019                         });
            //Id = 36 ,  Nome = "Aliquet Molestie Tellus Corp.                     8.779  1   05/07/2019                });
            //Id = 37 ,  Nome = "Ipsum Corp.                                5.568  15  10/03/2019                       });
            //Id = 38 ,  Nome = "Mi Lacinia Foundation                      7.442  20  09/07/2019                       });
            //Id = 39 ,  Nome = "Cubilia Curae; Corp.                         8.421  7   26 / 05 / 2019                 });
            //Id = 40 ,  Nome = "Velit Sed Malesuada Associates                      9.841  6   07 / 11 / 2019          });
            //Id = 41 ,  Nome = "Duis Foundation                               9.849  6   08 / 12 / 2019                });
            //Id = 42 ,  Nome = "Erat Semper Consulting                      6.168  10  10 / 11 / 2019                  });
            //Id = 43 ,  Nome = "Turpis Inc.	                              7.758  7   12 / 08 / 2019                 });
            //Id = 44 ,  Nome = "Aenean Industries                                8.770  12  10 / 09 / 2019             });
            //Id = 45 ,  Nome = "Nulla Industries                                     8.884  8   10 / 11 / 2019         });
            //Id = 46 ,  Nome = "Semper Egestas Urna Inc.	                         9.428  11  26 / 06 / 2019          });
            //Id = 47 ,  Nome = "Donec Luctus Aliquet Industries                        5.928  8   11 / 07 / 2019       });
            //Id = 48 ,  Nome = "Cum Sociis Natoque Foundation                   7.506  2   21 / 07 / 2019              });
            //Id = 49 ,  Nome = "Vitae Sodales Limited                                     8.912  8   22 / 06 / 2019    });
            //Id = 50 ,  Nome = "Tellus Sem Mollis Ltd                                        9.615  20  30 / 10 / 2019
            //Id = 51 ,  Nome = "Nulla Tincidunt LLC                                    5.562  19  22 / 09 / 2019
            //Id = 52 ,  Nome = "Sed Dictum Institute                                   9.243  14  26 / 06 / 2019
            //Id = 53 ,  Nome = "Sed Turpis Company                                       7.243  14  20 / 08 / 2019
            //Id = 54 ,  Nome = "Vitae Diam Proin Associates                            6.631  2   10 / 06 / 2019
            //Id = 55 ,  Nome = "Curabitur Inc.	                                               8.090  3   09 / 02 / 2019
            //Id = 56 ,  Nome = "Suscipit Est Ac LLC                              8.567  15  08 / 03 / 2019
            //Id = 57 ,  Nome = "Neque Morbi Industries                              5.171  1   03 / 10 / 2019
            //Id = 58 ,  Nome = "Non Ltd                                                5.102  19  14 / 08 / 2019
            //Id = 59 ,  Nome = "Arcu Vestibulum Ante Institute              6.128  1   08 / 10 / 2019
            //Id = 60 ,  Nome = "Nulla Foundation                                            7.636  6   14 / 04 / 2019
            //Id = 61 ,  Nome = "Quis Massa Mauris LLP                                      5.053  3   09 / 10 / 2019
            //Id = 62 ,  Nome = "Ut Incorporated                              6.922  17  16 / 09 / 2019
            //Id = 63 ,  Nome = "Aenean Egestas Corp.                                           8.142  19  17 / 11 / 2019
            //Id = 64 ,  Nome = "Fusce Mi Lorem Consulting                          8.312  20  19 / 11 / 2019
            //Id = 65 ,  Nome = "A Sollicitudin Orci PC                              5.864  1   20 / 03 / 2019
            //Id = 66 ,  Nome = "Sociosqu Limited                              5.985  12  28 / 11 / 2019
            //Id = 67 ,  Nome = "Ullamcorper Duis Cursus LLC                            5.164  7   22 / 12 / 2019
            //Id = 68 ,  Nome = "Nibh Lacinia LLC                                        7.760  10  13 / 06 / 2019
            //Id = 69 ,  Nome = "Eu Dui Institute                                     7.695  8   12 / 12 / 2019
            //Id = 70 ,  Nome = "Fringilla Purus Mauris Consulting                   5.845  6   01 / 03 / 2019
            //Id = 71 ,  Nome = "Donec Tempus Lorem Industries                       8.472  19  09 / 03 / 2019
            //Id = 72 ,  Nome = "Auctor Incorporated                         6.795  1   04 / 10 / 2019
            //Id = 73 ,  Nome = "Enim Etiam Imperdiet Corporation                     6.532  13  14 / 10 / 2019
            //Id = 74 ,  Nome = "Non Cursus Non Industries                        9.569  16  25 / 10 / 2019
            //Id = 75 ,  Nome = "Ut Semper Incorporated                           5.760  18  14 / 01 / 2019
            //Id = 76 ,  Nome = "Sed Malesuada Corporation                    6.561  4   06 / 03 / 2019
            //Id = 77 ,  Nome = "Sed Neque Consulting                         7.308  2   31 / 08 / 2019
            //Id = 78 ,  Nome = "Nisl Arcu PC                                         7.260  8   19 / 06 / 2019
            //Id = 79 ,  Nome = "Euismod Est Consulting                   6.020  11  27 / 10 / 2019
            //Id = 80 ,  Nome = "Leo Vivamus Ltd                                         5.055  8   22 / 10 / 2019
            //Id = 81 ,  Nome = "Tristique Neque Inc.                         9.268  13  25 / 02 / 2019
            //Id = 82 ,  Nome = "In Lobortis PC                                                    5.539  4   18 / 12 / 2019
            //Id = 83 ,  Nome = "Nunc Ltd                                                      6.846  2   09 / 10 / 2019
            //Id = 84 ,  Nome = "Dictum Proin Limited                                                        5.543  12  05 / 10 / 2019
            //Id = 85 ,  Nome = "Erat Vitae LLP                                            5.060  7   12 / 12 / 2019
            //Id = 86 ,  Nome = "Pellentesque Ultricies Dignissim PC                                       7.971  15  25 / 10 / 2019
            //Id = 87 ,  Nome = "Phasellus Elit Company                                        5.350  15  31 / 10 / 2019
            //Id = 88 ,  Nome = "Luctus Felis Ltd                                           9.872  13  06 / 01 / 2019
            //Id = 89 ,  Nome = "Dui Suspendisse PC                                                   6.878  7   06 / 02 / 2019
            //Id = 90 ,  Nome = "Odio Associates                                              7.636  18  24 / 07 / 2019
            //Id = 91 ,  Nome = "Vel Company                                              7.410  5   16 / 02 / 2019
            //Id = 92 ,  Nome = "Lobortis Institute                                      5.110  8   27 / 05 / 2019
            //Id = 93 ,  Nome = "Scelerisque Company                                     7.983  19  03 / 12 / 2019
            //Id = 94 ,  Nome = "Posuere Enim Company                                                        6.968  19  22 / 04 / 2019
            //Id = 95 ,  Nome = "Sem Ut Corp.                                                           6.504  11  02 / 02 / 2019
            //Id = 96 ,  Nome = "Dui Fusce Aliquam PC                                  7.837  2   08 / 12 / 2019
            //Id = 97 ,  Nome = "Nisl Sem Industries                              6.835  5   14 / 11 / 2019
            //Id = 98 ,  Nome = "Vitae Corp.	                                         7.669  7   09 / 11 / 2019
            //Id = 99 ,  Nome = "Malesuada Incorporated                               5.960  4   26 / 09 / 2019
            //Id = 100,  Nome = "Mauris Ltd                                            8.974  18  16 / 05 / 2019




        }
    }
}
