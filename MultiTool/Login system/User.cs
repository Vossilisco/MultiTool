using System;

namespace MultiTool.Login_system {
    class User {

        private string username;
        private string password;

        public User(string u, string p) {
            this.username = u;
            this.password = p;
        }

        public string getUsername() {
            return this.username;
        }

        public void setUsername(String name) {
            this.username = name;
        }

        public string getPassword() {
            return this.password;
        }

        public void setPassword(String pass) {
            this.password = pass;
        }
    }
}
