﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;

namespace BooksStoreBL
{
    public class BookStoreBL
    {
        List<BookDetails> ListOfBooks;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }

    }
}
