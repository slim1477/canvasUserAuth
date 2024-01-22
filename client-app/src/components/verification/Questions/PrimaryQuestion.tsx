import React from "react";
import {
  Accordion,
  AccordionContent,
  AccordionItem,
  AccordionTrigger,
} from "@/components/ui/accordion";

export const PrimaryQuestion = () => {
  return (
    <section>
      <Accordion type="single" collapsible className="w-full">
        <AccordionItem value="item-1">
          <AccordionTrigger>Primary Question 1</AccordionTrigger>
          <AccordionContent>
            Type of account and account balance
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-2">
          <AccordionTrigger>Primary Question 2</AccordionTrigger>
          <AccordionContent>Last 5 Transactions in Account</AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-3">
          <AccordionTrigger>Primary Question 3</AccordionTrigger>
          <AccordionContent>
            Loan Accounts? Payment amount and frequency
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-4">
          <AccordionTrigger>Primary Question 4</AccordionTrigger>
          <AccordionContent>
            Recurring debits or credits e.g payroll, bill payment, CRA e.t.c
          </AccordionContent>
        </AccordionItem>
        <AccordionItem value="item-5">
          <AccordionTrigger>Primary Question 5</AccordionTrigger>
          <AccordionContent>Last 5 Debit Card Transactions</AccordionContent>
        </AccordionItem>
      </Accordion>
    </section>
  );
};
