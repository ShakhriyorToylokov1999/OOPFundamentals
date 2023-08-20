using OOPFundamentals.DAL;
using OOPFundamentals.Entities;
using OOPFundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFundamentals.Service
{
    internal class FileManagerService
    {
        private readonly FileManager _fileManager;

        public FileManagerService(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public void WriteCard<T>(string number, T document) where T : IDocument
        {
            _fileManager.WriteCard(number, document);
        }

        public List<string> Search<T>(string number) where T : IDocument
        {
            var document = _fileManager.ReadCard<T>(number);
            if (document == null)
            {
                return new List<string>();
            }

            var cardInfo = new List<string>
            {
                $"Title: {document.Title}",
                $"Authors: {string.Join(", ", document.Authors)}",
                $"Date Published: {document.DatePublished.ToShortDateString()}"
            };

            if (document is Patent patent)
            {
                cardInfo.Add($"Unique ID: {patent.UniqueId}");
                cardInfo.Add($"Expiration Date: {patent.ExpirationDate.ToShortDateString()}");
            }
            else if (document is Book book)
            {
                cardInfo.Add($"ISBN: {book.ISBN}");
                cardInfo.Add($"Number of Pages: {book.NumberOfPages}");
                cardInfo.Add($"Publisher: {book.Publisher}");
            }
            else if (document is LocalizedBook localizedBook)
            {
                cardInfo.Add($"ISBN: {localizedBook.ISBN}");
                cardInfo.Add($"Number of Pages: {localizedBook.NumberOfPages}");
                cardInfo.Add($"Original Publisher: {localizedBook.OriginalPublisher}");
                cardInfo.Add($"Country of Localization: {localizedBook.CountryOfLocalization}");
                cardInfo.Add($"Local Publisher: {localizedBook.LocalPublisher}");
            }
            else if (document is Magazine magazine)
            {
                cardInfo.Add($"Publisher: {magazine.Publisher}");
                cardInfo.Add($"Release Number: {magazine.ReleaseNumber}");
            }

            return cardInfo;
        }
    }
}
