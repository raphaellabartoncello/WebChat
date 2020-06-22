using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebChat.Models;

namespace WebChat.Db
{
    public class ChatDb
    {
        private const string chaveChat = "chat";
        private const string chaveparticipantes = "participantes";
        private const string adminNome = "admin";
        private const string adminMensagemInicial = "Chat Iniciado com sucesso";

        //
        // Iniciar: Cria os itens da aplicação
        //
        internal static void Iniciar()
        {
            // Lista de Mensagens
            var lista = new List<ChatMensagem>();
            HttpContext.Current.Application.Add(chaveChat, lista);
            // Lista de Participantes On-Line
            var participantes = new List<string>();
            HttpContext.Current.Application.Add(chaveparticipantes, participantes);
            participantes.Add(adminNome);
        }

    }

}