import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger,
} from "@/components/ui/accordion";

export const PersonalInfo = () => {
  return (
    <div>
      <Accordion type="single" collapsible className="w-full">
        <AccordionItem
          disabled
          className="px-3 py-1.5 rounded-lg shadow-sm"
          value="item-1"
        >
          <AccordionTrigger>
            <section className="flex items-center gap-3">
              Personal Details
            </section>
          </AccordionTrigger>
          <AccordionContent>
            Type of account and account balance
          </AccordionContent>
        </AccordionItem>
        <AccordionItem
          disabled
          className="px-3 py-1.5 rounded-lg shadow-sm"
          value="item-2"
        >
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              Contact Information
            </section>
          </AccordionTrigger>
          <AccordionContent>Last 5 Transactions in Account</AccordionContent>
        </AccordionItem>
        <AccordionItem
          disabled
          className="px-3 py-1.5 rounded-lg shadow-sm"
          value="item-3"
        >
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">Address</section>
          </AccordionTrigger>
          <AccordionContent>
            Loan Accounts? Payment amount and frequency
          </AccordionContent>
        </AccordionItem>
        <AccordionItem
          disabled
          className="px-3 py-1.5 rounded-lg shadow-sm"
          value="item-4"
        >
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              Identification
            </section>
          </AccordionTrigger>
          <AccordionContent>
            Recurring debits or credits e.g payroll, bill payment, CRA e.t.c
          </AccordionContent>
        </AccordionItem>
        <AccordionItem
          disabled
          className="px-3 py-1.5 rounded-lg shadow-sm"
          value="item-5"
        >
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              Tax Residing & Citizenship
            </section>
          </AccordionTrigger>
          <AccordionContent>Last 5 Debit Card Transactions</AccordionContent>
        </AccordionItem>
        <AccordionItem
          disabled
          className="px-3 py-1.5 rounded-lg shadow-sm"
          value="item-5"
        >
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">Other</section>
          </AccordionTrigger>
          <AccordionContent>Last 5 Debit Card Transactions</AccordionContent>
        </AccordionItem>
        <AccordionItem
          disabled
          className="px-3 py-1.5 rounded-lg shadow-sm"
          value="item-5"
        >
          <AccordionTrigger>
            {" "}
            <section className="flex items-center gap-3">
              Withdrawal Of Consent
            </section>
          </AccordionTrigger>
          <AccordionContent>Last 5 Debit Card Transactions</AccordionContent>
        </AccordionItem>
      </Accordion>
    </div>
  );
};
