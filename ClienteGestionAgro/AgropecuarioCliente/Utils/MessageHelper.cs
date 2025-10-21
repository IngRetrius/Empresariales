using System;
using System.Windows.Forms;

namespace AgropecuarioCliente.Utils
{
    public static class MessageHelper
    {
        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Overload to show exception details with optional prefix message
        public static void ShowError(System.Exception ex, string prefixMessage = null)
        {
            if (ex == null)
            {
                ShowError(prefixMessage ?? "Ocurrió un error desconocido.");
                return;
            }

            var fullMessage = string.IsNullOrWhiteSpace(prefixMessage)
                ? ex.Message
                : prefixMessage + "\n\n" + ex.Message;

            MessageBox.Show(fullMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // MÉTODO FALTANTE AGREGADO
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowConfirmation(string message)
        {
            return MessageBox.Show(message, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static DialogResult ShowQuestion(string message, string title = "Pregunta")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}