using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.State {


    /// <summary>
    /// this is the context class.  this is the class that holds a state.  the state on the
    /// other hand is the class that has the behavior that changes.  each state has a different
    /// behavior like the strategy pattern.   the state changes the state of the context object.
    /// the context objects initializes the state at first
    /// </summary>
    public class Account {
        private State _state;
        private string _owner;

        // Constructor
        public Account(string owner) {
            // New accounts are 'Silver' by default
            this._owner = owner;
            this._state = new SilverState(0.0, this);
        }

        // Properties
        public double Balance {
            get { return _state.Balance; }
        }

        public State State {
            get { return _state; }
            set { _state = value; }
        }

        public void Deposit(double amount) {
            _state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}",
              this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount) {
            _state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              this.State.GetType().Name);
        }

        public void PayInterest() {
            _state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              this.State.GetType().Name);
        }
    }
}
